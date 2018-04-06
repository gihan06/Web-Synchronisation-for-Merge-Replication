

Imports Microsoft.SqlServer.Replication
Imports Microsoft.SqlServer.Management.Common

Public Class Form1

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WattsALoanSubDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WattsALoanSubDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.WattsALoanSubDataSet.Customers)

    End Sub

    Private Sub UpdateCustomerBotton_Click(sender As Object, e As EventArgs) Handles UpdateCustomerBotton.Click
        Me.QueriesTableAdapter1.UpdateCustomer(CustomerIDTextBox.Text, DateCreatedDateTimePicker.Value, FullNameTextBox.Text, BillingAddressTextBox.Text, BillingCityTextBox.Text, BillingStateTextBox.Text, BillingZIPCideTextBox.Text, EmailAddressTextBox.Text)
    End Sub


    Private Sub SynchronisationBotton_Click(sender As Object, e As EventArgs) Handles SynchronisationBotton.Click
        Dim subscriberName As String = "PE205-12" 'Machine name of subcriber 
        Dim publisherName As String = "PE205-12" 'Machine name of publisher 
        Dim publicationName As String = "WattsALoanPub" 'Name given to publication when publication first created using wizard
        Dim subscriptionDbName As String = "WattsALoanSub" 'Name of subscription database
        Dim publicationDbName As String = "WattsALoanPub" 'Name of publication database
        Dim hostname As String = "PCSUPPORT\RepListen" 'Machine name and username of account used by replication agents 
        Dim webSyncUrl As String = "https://" + "pe205-12.pcsupport.ac.nz" + "/SQLReplication/replisapi.dll" 'Issued-to name of self signed certificate + folder of replisapi.dll

        ' Create a connection to the Subscriber.
        Dim conn As ServerConnection = New ServerConnection(subscriberName)

        Dim subscription As MergePullSubscription
        Dim agent As MergeSynchronizationAgent

        Try
            ' Connect to the Subscriber.
            conn.Connect()

            ' Define the pull subscription.
            subscription = New MergePullSubscription()
            subscription.ConnectionContext = conn
            subscription.DatabaseName = subscriptionDbName
            subscription.PublisherName = publisherName
            subscription.PublicationDBName = publicationDbName
            subscription.PublicationName = publicationName

            ' If the pull subscription exists, then start the synchronization.
            If subscription.LoadProperties() Then
                ' Get the agent for the subscription.
                agent = subscription.SynchronizationAgent

                ' Check that we have enough metadata to start the agent.
                If agent.PublisherSecurityMode = Nothing Then
                    ' Set the required properties that could not be returned
                    ' from the MSsubscription_properties table. 
                    agent.PublisherSecurityMode = SecurityMode.Integrated
                    agent.Distributor = "PE205-12" 'Machine name where distributor located - yours will begin with PE203 or PE204
                    agent.DistributorSecurityMode = SecurityMode.Integrated
                    agent.HostName = hostname

                    ' Set optional Web synchronization properties.
                    agent.UseWebSynchronization = True
                    agent.InternetUrl = webSyncUrl
                    agent.InternetSecurityMode = SecurityMode.Standard
                    agent.InternetLogin = "PCSUPPORT\RepListen" 'Machine name and username of account used by replication agents
                    agent.InternetPassword = "" 'password not required - integrated security used instead
                End If

                ' Enable agent logging to the console.
                agent.OutputVerboseLevel = 1
                agent.Output = ""

                ' Synchronously start the Merge Agent for the subscription.
                agent.Synchronize()
            Else
                ' Do something here if the pull subscription does not exist.
                Throw New ApplicationException(String.Format( _
                 "A subscription to '{0}' does not exist on {1}", _
                 publicationName, subscriberName))
            End If
        Catch ex As Exception
            ' Implement appropriate error handling here.
            Throw New ApplicationException("The subscription could not be " + _
             "synchronized. Verify that the subscription has " + _
             "been defined correctly.", ex)
        Finally
            conn.Disconnect()
            MsgBox("Success!!")
        End Try

    End Sub
End Class
