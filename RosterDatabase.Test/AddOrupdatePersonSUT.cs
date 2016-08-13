using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;

namespace RoasterDatabase.Test.Test
{
    [TestClass()]
    public class AddOrupdatePersonSUT : SqlDatabaseTestClass
    {

        private TransactionScope transactionScope;

        public AddOrupdatePersonSUT()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            transactionScope = new TransactionScope();
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
            transactionScope.Dispose();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction CanCreatePerson_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrupdatePersonSUT));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition PersonId;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ShouldUpdatePersonNameIfExists_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition SashaId;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ShouldAlsoAddItemsIfAny_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ShouldUpdateInventory_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ShouldUpdateItemName_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition RazorItemName;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition ConadomsItemName;
            this.CanCreatePersonData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ShouldUpdatePersonNameIfExistsData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ShouldAlsoAddItemsIfAnyData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ShouldUpdateInventoryData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ShouldUpdateItemNameData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            CanCreatePerson_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            PersonId = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            ShouldUpdatePersonNameIfExists_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            SashaId = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            ShouldAlsoAddItemsIfAny_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            ShouldUpdateInventory_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            ShouldUpdateItemName_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            RazorItemName = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            ConadomsItemName = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // CanCreatePerson_TestAction
            // 
            CanCreatePerson_TestAction.Conditions.Add(PersonId);
            resources.ApplyResources(CanCreatePerson_TestAction, "CanCreatePerson_TestAction");
            // 
            // PersonId
            // 
            PersonId.ColumnNumber = 1;
            PersonId.Enabled = true;
            PersonId.ExpectedValue = "1";
            PersonId.Name = "PersonId";
            PersonId.NullExpected = false;
            PersonId.ResultSet = 1;
            PersonId.RowNumber = 1;
            // 
            // CanCreatePersonData
            // 
            this.CanCreatePersonData.PosttestAction = null;
            this.CanCreatePersonData.PretestAction = null;
            this.CanCreatePersonData.TestAction = CanCreatePerson_TestAction;
            // 
            // ShouldUpdatePersonNameIfExistsData
            // 
            this.ShouldUpdatePersonNameIfExistsData.PosttestAction = null;
            this.ShouldUpdatePersonNameIfExistsData.PretestAction = null;
            this.ShouldUpdatePersonNameIfExistsData.TestAction = ShouldUpdatePersonNameIfExists_TestAction;
            // 
            // ShouldUpdatePersonNameIfExists_TestAction
            // 
            ShouldUpdatePersonNameIfExists_TestAction.Conditions.Add(SashaId);
            resources.ApplyResources(ShouldUpdatePersonNameIfExists_TestAction, "ShouldUpdatePersonNameIfExists_TestAction");
            // 
            // SashaId
            // 
            SashaId.ColumnNumber = 1;
            SashaId.Enabled = true;
            SashaId.ExpectedValue = "1";
            SashaId.Name = "SashaId";
            SashaId.NullExpected = false;
            SashaId.ResultSet = 1;
            SashaId.RowNumber = 1;
            // 
            // ShouldAlsoAddItemsIfAnyData
            // 
            this.ShouldAlsoAddItemsIfAnyData.PosttestAction = null;
            this.ShouldAlsoAddItemsIfAnyData.PretestAction = null;
            this.ShouldAlsoAddItemsIfAnyData.TestAction = ShouldAlsoAddItemsIfAny_TestAction;
            // 
            // ShouldAlsoAddItemsIfAny_TestAction
            // 
            ShouldAlsoAddItemsIfAny_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(ShouldAlsoAddItemsIfAny_TestAction, "ShouldAlsoAddItemsIfAny_TestAction");
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 1;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "2";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // ShouldUpdateInventoryData
            // 
            this.ShouldUpdateInventoryData.PosttestAction = null;
            this.ShouldUpdateInventoryData.PretestAction = null;
            this.ShouldUpdateInventoryData.TestAction = ShouldUpdateInventory_TestAction;
            // 
            // ShouldUpdateInventory_TestAction
            // 
            ShouldUpdateInventory_TestAction.Conditions.Add(scalarValueCondition2);
            resources.ApplyResources(ShouldUpdateInventory_TestAction, "ShouldUpdateInventory_TestAction");
            // 
            // scalarValueCondition2
            // 
            scalarValueCondition2.ColumnNumber = 1;
            scalarValueCondition2.Enabled = true;
            scalarValueCondition2.ExpectedValue = "2";
            scalarValueCondition2.Name = "scalarValueCondition2";
            scalarValueCondition2.NullExpected = false;
            scalarValueCondition2.ResultSet = 1;
            scalarValueCondition2.RowNumber = 1;
            // 
            // ShouldUpdateItemNameData
            // 
            this.ShouldUpdateItemNameData.PosttestAction = null;
            this.ShouldUpdateItemNameData.PretestAction = null;
            this.ShouldUpdateItemNameData.TestAction = ShouldUpdateItemName_TestAction;
            // 
            // ShouldUpdateItemName_TestAction
            // 
            ShouldUpdateItemName_TestAction.Conditions.Add(RazorItemName);
            ShouldUpdateItemName_TestAction.Conditions.Add(ConadomsItemName);
            resources.ApplyResources(ShouldUpdateItemName_TestAction, "ShouldUpdateItemName_TestAction");
            // 
            // RazorItemName
            // 
            RazorItemName.ColumnNumber = 1;
            RazorItemName.Enabled = true;
            RazorItemName.ExpectedValue = "Razor";
            RazorItemName.Name = "RazorItemName";
            RazorItemName.NullExpected = false;
            RazorItemName.ResultSet = 1;
            RazorItemName.RowNumber = 1;
            // 
            // ConadomsItemName
            // 
            ConadomsItemName.ColumnNumber = 1;
            ConadomsItemName.Enabled = true;
            ConadomsItemName.ExpectedValue = "Candoms";
            ConadomsItemName.Name = "ConadomsItemName";
            ConadomsItemName.NullExpected = false;
            ConadomsItemName.ResultSet = 2;
            ConadomsItemName.RowNumber = 1;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void CanCreatePerson()
        {
            SqlDatabaseTestActions testActions = this.CanCreatePersonData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void ShouldUpdatePersonNameIfExists()
        {
            SqlDatabaseTestActions testActions = this.ShouldUpdatePersonNameIfExistsData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void ShouldAlsoAddItemsIfAny()
        {
            SqlDatabaseTestActions testActions = this.ShouldAlsoAddItemsIfAnyData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void ShouldUpdateInventory()
        {
            SqlDatabaseTestActions testActions = this.ShouldUpdateInventoryData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void ShouldUpdateItemName()
        {
            SqlDatabaseTestActions testActions = this.ShouldUpdateItemNameData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }




        private SqlDatabaseTestActions CanCreatePersonData;
        private SqlDatabaseTestActions ShouldUpdatePersonNameIfExistsData;
        private SqlDatabaseTestActions ShouldAlsoAddItemsIfAnyData;
        private SqlDatabaseTestActions ShouldUpdateInventoryData;
        private SqlDatabaseTestActions ShouldUpdateItemNameData;
    }
}
