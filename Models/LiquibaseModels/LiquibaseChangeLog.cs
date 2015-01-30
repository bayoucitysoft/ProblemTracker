using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTracker.Models.LiquibaseModels
{
    public class LiquibaseChangeLog
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class databaseChangeLog
        {

            private databaseChangeLogPreConditions preConditionsField;

            private databaseChangeLogProperty propertyField;

            private databaseChangeLogChangeSet[] changeSetField;

            private databaseChangeLogInclude includeField;

            private databaseChangeLogIncludeAll includeAllField;

            private string logicalFilePathField;

            /// <remarks/>
            public databaseChangeLogPreConditions preConditions
            {
                get
                {
                    return this.preConditionsField;
                }
                set
                {
                    this.preConditionsField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogProperty property
            {
                get
                {
                    return this.propertyField;
                }
                set
                {
                    this.propertyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("changeSet")]
            public databaseChangeLogChangeSet[] changeSet
            {
                get
                {
                    return this.changeSetField;
                }
                set
                {
                    this.changeSetField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogInclude include
            {
                get
                {
                    return this.includeField;
                }
                set
                {
                    this.includeField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogIncludeAll includeAll
            {
                get
                {
                    return this.includeAllField;
                }
                set
                {
                    this.includeAllField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string logicalFilePath
            {
                get
                {
                    return this.logicalFilePathField;
                }
                set
                {
                    this.logicalFilePathField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogPreConditions
        {

            private string onFailField;

            private string onErrorField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string onFail
            {
                get
                {
                    return this.onFailField;
                }
                set
                {
                    this.onFailField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string onError
            {
                get
                {
                    return this.onErrorField;
                }
                set
                {
                    this.onErrorField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogProperty
        {

            private string fileField;

            private string nameField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string file
            {
                get
                {
                    return this.fileField;
                }
                set
                {
                    this.fileField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSet
        {

            private databaseChangeLogChangeSetValidCheckSum validCheckSumField;

            private databaseChangeLogChangeSetPreConditions preConditionsField;

            private databaseChangeLogChangeSetTagDatabase tagDatabaseField;

            private string commentField;

            private databaseChangeLogChangeSetCreateTable createTableField;

            private databaseChangeLogChangeSetDropTable dropTableField;

            private databaseChangeLogChangeSetCreateView createViewField;

            private databaseChangeLogChangeSetRenameView renameViewField;

            private databaseChangeLogChangeSetDropView dropViewField;

            private databaseChangeLogChangeSetInsert insertField;

            private databaseChangeLogChangeSetAddColumn addColumnField;

            private databaseChangeLogChangeSetSql[] sqlField;

            private databaseChangeLogChangeSetCreateProcedure createProcedureField;

            private databaseChangeLogChangeSetSqlFile sqlFileField;

            private databaseChangeLogChangeSetRenameTable renameTableField;

            private databaseChangeLogChangeSetRenameColumn renameColumnField;

            private databaseChangeLogChangeSetDropColumn dropColumnField;

            private databaseChangeLogChangeSetModifyColumn modifyColumnField;

            private databaseChangeLogChangeSetMergeColumns mergeColumnsField;

            private databaseChangeLogChangeSetCreateSequence createSequenceField;

            private databaseChangeLogChangeSetAlterSequence alterSequenceField;

            private databaseChangeLogChangeSetDropSequence dropSequenceField;

            private databaseChangeLogChangeSetCreateIndex createIndexField;

            private databaseChangeLogChangeSetDropIndex dropIndexField;

            private databaseChangeLogChangeSetAddNotNullConstraint addNotNullConstraintField;

            private databaseChangeLogChangeSetDropNotNullConstraint dropNotNullConstraintField;

            private databaseChangeLogChangeSetAddForeignKeyConstraint[] addForeignKeyConstraintField;

            private databaseChangeLogChangeSetDropForeignKeyConstraint dropForeignKeyConstraintField;

            private databaseChangeLogChangeSetDropAllForeignKeyConstraints dropAllForeignKeyConstraintsField;

            private databaseChangeLogChangeSetAddPrimaryKey addPrimaryKeyField;

            private databaseChangeLogChangeSetDropPrimaryKey dropPrimaryKeyField;

            private databaseChangeLogChangeSetAddLookupTable addLookupTableField;

            private databaseChangeLogChangeSetAddAutoIncrement addAutoIncrementField;

            private databaseChangeLogChangeSetAddDefaultValue addDefaultValueField;

            private databaseChangeLogChangeSetDropDefaultValue dropDefaultValueField;

            private databaseChangeLogChangeSetAddUniqueConstraint addUniqueConstraintField;

            private databaseChangeLogChangeSetDropUniqueConstraint dropUniqueConstraintField;

            private databaseChangeLogChangeSetCustomChange customChangeField;

            private databaseChangeLogChangeSetUpdate updateField;

            private databaseChangeLogChangeSetDelete deleteField;

            private databaseChangeLogChangeSetLoadData loadDataField;

            private databaseChangeLogChangeSetExecuteCommand executeCommandField;

            private object stopField;

            private databaseChangeLogChangeSetRollback rollbackField;

            private databaseChangeLogChangeSetModifySql modifySqlField;

            private string idField;

            private string authorField;

            private string contextField;

            private string dbmsField;

            private bool runOnChangeField;

            private bool runOnChangeFieldSpecified;

            private bool runAlwaysField;

            private bool runAlwaysFieldSpecified;

            private bool failOnErrorField;

            private bool failOnErrorFieldSpecified;

            private bool runInTransactionField;

            private bool runInTransactionFieldSpecified;

            /// <remarks/>
            public databaseChangeLogChangeSetValidCheckSum validCheckSum
            {
                get
                {
                    return this.validCheckSumField;
                }
                set
                {
                    this.validCheckSumField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetPreConditions preConditions
            {
                get
                {
                    return this.preConditionsField;
                }
                set
                {
                    this.preConditionsField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetTagDatabase tagDatabase
            {
                get
                {
                    return this.tagDatabaseField;
                }
                set
                {
                    this.tagDatabaseField = value;
                }
            }

            /// <remarks/>
            public string comment
            {
                get
                {
                    return this.commentField;
                }
                set
                {
                    this.commentField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetCreateTable createTable
            {
                get
                {
                    return this.createTableField;
                }
                set
                {
                    this.createTableField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetDropTable dropTable
            {
                get
                {
                    return this.dropTableField;
                }
                set
                {
                    this.dropTableField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetCreateView createView
            {
                get
                {
                    return this.createViewField;
                }
                set
                {
                    this.createViewField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetRenameView renameView
            {
                get
                {
                    return this.renameViewField;
                }
                set
                {
                    this.renameViewField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetDropView dropView
            {
                get
                {
                    return this.dropViewField;
                }
                set
                {
                    this.dropViewField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetInsert insert
            {
                get
                {
                    return this.insertField;
                }
                set
                {
                    this.insertField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetAddColumn addColumn
            {
                get
                {
                    return this.addColumnField;
                }
                set
                {
                    this.addColumnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("sql")]
            public databaseChangeLogChangeSetSql[] sql
            {
                get
                {
                    return this.sqlField;
                }
                set
                {
                    this.sqlField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetCreateProcedure createProcedure
            {
                get
                {
                    return this.createProcedureField;
                }
                set
                {
                    this.createProcedureField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetSqlFile sqlFile
            {
                get
                {
                    return this.sqlFileField;
                }
                set
                {
                    this.sqlFileField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetRenameTable renameTable
            {
                get
                {
                    return this.renameTableField;
                }
                set
                {
                    this.renameTableField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetRenameColumn renameColumn
            {
                get
                {
                    return this.renameColumnField;
                }
                set
                {
                    this.renameColumnField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetDropColumn dropColumn
            {
                get
                {
                    return this.dropColumnField;
                }
                set
                {
                    this.dropColumnField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetModifyColumn modifyColumn
            {
                get
                {
                    return this.modifyColumnField;
                }
                set
                {
                    this.modifyColumnField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetMergeColumns mergeColumns
            {
                get
                {
                    return this.mergeColumnsField;
                }
                set
                {
                    this.mergeColumnsField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetCreateSequence createSequence
            {
                get
                {
                    return this.createSequenceField;
                }
                set
                {
                    this.createSequenceField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetAlterSequence alterSequence
            {
                get
                {
                    return this.alterSequenceField;
                }
                set
                {
                    this.alterSequenceField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetDropSequence dropSequence
            {
                get
                {
                    return this.dropSequenceField;
                }
                set
                {
                    this.dropSequenceField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetCreateIndex createIndex
            {
                get
                {
                    return this.createIndexField;
                }
                set
                {
                    this.createIndexField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetDropIndex dropIndex
            {
                get
                {
                    return this.dropIndexField;
                }
                set
                {
                    this.dropIndexField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetAddNotNullConstraint addNotNullConstraint
            {
                get
                {
                    return this.addNotNullConstraintField;
                }
                set
                {
                    this.addNotNullConstraintField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetDropNotNullConstraint dropNotNullConstraint
            {
                get
                {
                    return this.dropNotNullConstraintField;
                }
                set
                {
                    this.dropNotNullConstraintField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("addForeignKeyConstraint")]
            public databaseChangeLogChangeSetAddForeignKeyConstraint[] addForeignKeyConstraint
            {
                get
                {
                    return this.addForeignKeyConstraintField;
                }
                set
                {
                    this.addForeignKeyConstraintField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetDropForeignKeyConstraint dropForeignKeyConstraint
            {
                get
                {
                    return this.dropForeignKeyConstraintField;
                }
                set
                {
                    this.dropForeignKeyConstraintField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetDropAllForeignKeyConstraints dropAllForeignKeyConstraints
            {
                get
                {
                    return this.dropAllForeignKeyConstraintsField;
                }
                set
                {
                    this.dropAllForeignKeyConstraintsField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetAddPrimaryKey addPrimaryKey
            {
                get
                {
                    return this.addPrimaryKeyField;
                }
                set
                {
                    this.addPrimaryKeyField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetDropPrimaryKey dropPrimaryKey
            {
                get
                {
                    return this.dropPrimaryKeyField;
                }
                set
                {
                    this.dropPrimaryKeyField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetAddLookupTable addLookupTable
            {
                get
                {
                    return this.addLookupTableField;
                }
                set
                {
                    this.addLookupTableField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetAddAutoIncrement addAutoIncrement
            {
                get
                {
                    return this.addAutoIncrementField;
                }
                set
                {
                    this.addAutoIncrementField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetAddDefaultValue addDefaultValue
            {
                get
                {
                    return this.addDefaultValueField;
                }
                set
                {
                    this.addDefaultValueField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetDropDefaultValue dropDefaultValue
            {
                get
                {
                    return this.dropDefaultValueField;
                }
                set
                {
                    this.dropDefaultValueField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetAddUniqueConstraint addUniqueConstraint
            {
                get
                {
                    return this.addUniqueConstraintField;
                }
                set
                {
                    this.addUniqueConstraintField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetDropUniqueConstraint dropUniqueConstraint
            {
                get
                {
                    return this.dropUniqueConstraintField;
                }
                set
                {
                    this.dropUniqueConstraintField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetCustomChange customChange
            {
                get
                {
                    return this.customChangeField;
                }
                set
                {
                    this.customChangeField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetUpdate update
            {
                get
                {
                    return this.updateField;
                }
                set
                {
                    this.updateField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetDelete delete
            {
                get
                {
                    return this.deleteField;
                }
                set
                {
                    this.deleteField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetLoadData loadData
            {
                get
                {
                    return this.loadDataField;
                }
                set
                {
                    this.loadDataField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetExecuteCommand executeCommand
            {
                get
                {
                    return this.executeCommandField;
                }
                set
                {
                    this.executeCommandField = value;
                }
            }

            /// <remarks/>
            public object stop
            {
                get
                {
                    return this.stopField;
                }
                set
                {
                    this.stopField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetRollback rollback
            {
                get
                {
                    return this.rollbackField;
                }
                set
                {
                    this.rollbackField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetModifySql modifySql
            {
                get
                {
                    return this.modifySqlField;
                }
                set
                {
                    this.modifySqlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string author
            {
                get
                {
                    return this.authorField;
                }
                set
                {
                    this.authorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string context
            {
                get
                {
                    return this.contextField;
                }
                set
                {
                    this.contextField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string dbms
            {
                get
                {
                    return this.dbmsField;
                }
                set
                {
                    this.dbmsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool runOnChange
            {
                get
                {
                    return this.runOnChangeField;
                }
                set
                {
                    this.runOnChangeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool runOnChangeSpecified
            {
                get
                {
                    return this.runOnChangeFieldSpecified;
                }
                set
                {
                    this.runOnChangeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool runAlways
            {
                get
                {
                    return this.runAlwaysField;
                }
                set
                {
                    this.runAlwaysField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool runAlwaysSpecified
            {
                get
                {
                    return this.runAlwaysFieldSpecified;
                }
                set
                {
                    this.runAlwaysFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool failOnError
            {
                get
                {
                    return this.failOnErrorField;
                }
                set
                {
                    this.failOnErrorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool failOnErrorSpecified
            {
                get
                {
                    return this.failOnErrorFieldSpecified;
                }
                set
                {
                    this.failOnErrorFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool runInTransaction
            {
                get
                {
                    return this.runInTransactionField;
                }
                set
                {
                    this.runInTransactionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool runInTransactionSpecified
            {
                get
                {
                    return this.runInTransactionFieldSpecified;
                }
                set
                {
                    this.runInTransactionFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetValidCheckSum
        {

            private string commentField;

            /// <remarks/>
            public string comment
            {
                get
                {
                    return this.commentField;
                }
                set
                {
                    this.commentField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetPreConditions
        {

            private databaseChangeLogChangeSetPreConditionsColumnExists columnExistsField;

            private databaseChangeLogChangeSetPreConditionsNot notField;

            private databaseChangeLogChangeSetPreConditionsSqlCheck sqlCheckField;

            private string onFailField;

            private string onErrorField;

            /// <remarks/>
            public databaseChangeLogChangeSetPreConditionsColumnExists columnExists
            {
                get
                {
                    return this.columnExistsField;
                }
                set
                {
                    this.columnExistsField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetPreConditionsNot not
            {
                get
                {
                    return this.notField;
                }
                set
                {
                    this.notField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetPreConditionsSqlCheck sqlCheck
            {
                get
                {
                    return this.sqlCheckField;
                }
                set
                {
                    this.sqlCheckField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string onFail
            {
                get
                {
                    return this.onFailField;
                }
                set
                {
                    this.onFailField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string onError
            {
                get
                {
                    return this.onErrorField;
                }
                set
                {
                    this.onErrorField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetPreConditionsColumnExists
        {

            private string columnNameField;

            private string tableNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string columnName
            {
                get
                {
                    return this.columnNameField;
                }
                set
                {
                    this.columnNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetPreConditionsNot
        {

            private databaseChangeLogChangeSetPreConditionsNotIndexExists indexExistsField;

            private databaseChangeLogChangeSetPreConditionsNotTableExists tableExistsField;

            private databaseChangeLogChangeSetPreConditionsNotSqlCheck sqlCheckField;

            private databaseChangeLogChangeSetPreConditionsNotColumnExists columnExistsField;

            /// <remarks/>
            public databaseChangeLogChangeSetPreConditionsNotIndexExists indexExists
            {
                get
                {
                    return this.indexExistsField;
                }
                set
                {
                    this.indexExistsField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetPreConditionsNotTableExists tableExists
            {
                get
                {
                    return this.tableExistsField;
                }
                set
                {
                    this.tableExistsField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetPreConditionsNotSqlCheck sqlCheck
            {
                get
                {
                    return this.sqlCheckField;
                }
                set
                {
                    this.sqlCheckField = value;
                }
            }

            /// <remarks/>
            public databaseChangeLogChangeSetPreConditionsNotColumnExists columnExists
            {
                get
                {
                    return this.columnExistsField;
                }
                set
                {
                    this.columnExistsField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetPreConditionsNotIndexExists
        {

            private string indexNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string indexName
            {
                get
                {
                    return this.indexNameField;
                }
                set
                {
                    this.indexNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetPreConditionsNotTableExists
        {

            private string schemaNameField;

            private string tableNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetPreConditionsNotSqlCheck
        {

            private byte expectedResultField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte expectedResult
            {
                get
                {
                    return this.expectedResultField;
                }
                set
                {
                    this.expectedResultField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetPreConditionsNotColumnExists
        {

            private string columnNameField;

            private string tableNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string columnName
            {
                get
                {
                    return this.columnNameField;
                }
                set
                {
                    this.columnNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetPreConditionsSqlCheck
        {

            private byte expectedResultField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte expectedResult
            {
                get
                {
                    return this.expectedResultField;
                }
                set
                {
                    this.expectedResultField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetTagDatabase
        {

            private string tagField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tag
            {
                get
                {
                    return this.tagField;
                }
                set
                {
                    this.tagField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetCreateTable
        {

            private databaseChangeLogChangeSetCreateTableColumn[] columnField;

            private string schemaNameField;

            private string tableNameField;

            private string tablespaceField;

            private string remarksField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("column")]
            public databaseChangeLogChangeSetCreateTableColumn[] column
            {
                get
                {
                    return this.columnField;
                }
                set
                {
                    this.columnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tablespace
            {
                get
                {
                    return this.tablespaceField;
                }
                set
                {
                    this.tablespaceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string remarks
            {
                get
                {
                    return this.remarksField;
                }
                set
                {
                    this.remarksField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetCreateTableColumn
        {

            private databaseChangeLogChangeSetCreateTableColumnConstraints constraintsField;

            private string nameField;

            private string typeField;

            private string valueField;

            private string valueNumericField;

            private string valueBooleanField;

            private string valueDateField;

            private string defaultValueField;

            private string defaultValueNumericField;

            private string defaultValueDateField;

            private bool defaultValueBooleanField;

            private bool defaultValueBooleanFieldSpecified;

            private bool autoIncrementField;

            private bool autoIncrementFieldSpecified;

            private string remarksField;

            /// <remarks/>
            public databaseChangeLogChangeSetCreateTableColumnConstraints constraints
            {
                get
                {
                    return this.constraintsField;
                }
                set
                {
                    this.constraintsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string valueNumeric
            {
                get
                {
                    return this.valueNumericField;
                }
                set
                {
                    this.valueNumericField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string valueBoolean
            {
                get
                {
                    return this.valueBooleanField;
                }
                set
                {
                    this.valueBooleanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string valueDate
            {
                get
                {
                    return this.valueDateField;
                }
                set
                {
                    this.valueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValue
            {
                get
                {
                    return this.defaultValueField;
                }
                set
                {
                    this.defaultValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValueNumeric
            {
                get
                {
                    return this.defaultValueNumericField;
                }
                set
                {
                    this.defaultValueNumericField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValueDate
            {
                get
                {
                    return this.defaultValueDateField;
                }
                set
                {
                    this.defaultValueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool defaultValueBoolean
            {
                get
                {
                    return this.defaultValueBooleanField;
                }
                set
                {
                    this.defaultValueBooleanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool defaultValueBooleanSpecified
            {
                get
                {
                    return this.defaultValueBooleanFieldSpecified;
                }
                set
                {
                    this.defaultValueBooleanFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool autoIncrement
            {
                get
                {
                    return this.autoIncrementField;
                }
                set
                {
                    this.autoIncrementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool autoIncrementSpecified
            {
                get
                {
                    return this.autoIncrementFieldSpecified;
                }
                set
                {
                    this.autoIncrementFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string remarks
            {
                get
                {
                    return this.remarksField;
                }
                set
                {
                    this.remarksField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetCreateTableColumnConstraints
        {

            private bool nullableField;

            private bool primaryKeyField;

            private bool primaryKeyFieldSpecified;

            private string primaryKeyNameField;

            private bool uniqueField;

            private bool uniqueFieldSpecified;

            private string uniqueConstraintNameField;

            private string referencesField;

            private string foreignKeyNameField;

            private bool deleteCascadeField;

            private bool deleteCascadeFieldSpecified;

            private bool deferrableField;

            private bool deferrableFieldSpecified;

            private bool initiallyDeferredField;

            private bool initiallyDeferredFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool nullable
            {
                get
                {
                    return this.nullableField;
                }
                set
                {
                    this.nullableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool primaryKey
            {
                get
                {
                    return this.primaryKeyField;
                }
                set
                {
                    this.primaryKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool primaryKeySpecified
            {
                get
                {
                    return this.primaryKeyFieldSpecified;
                }
                set
                {
                    this.primaryKeyFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string primaryKeyName
            {
                get
                {
                    return this.primaryKeyNameField;
                }
                set
                {
                    this.primaryKeyNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool unique
            {
                get
                {
                    return this.uniqueField;
                }
                set
                {
                    this.uniqueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool uniqueSpecified
            {
                get
                {
                    return this.uniqueFieldSpecified;
                }
                set
                {
                    this.uniqueFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string uniqueConstraintName
            {
                get
                {
                    return this.uniqueConstraintNameField;
                }
                set
                {
                    this.uniqueConstraintNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string references
            {
                get
                {
                    return this.referencesField;
                }
                set
                {
                    this.referencesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string foreignKeyName
            {
                get
                {
                    return this.foreignKeyNameField;
                }
                set
                {
                    this.foreignKeyNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool deleteCascade
            {
                get
                {
                    return this.deleteCascadeField;
                }
                set
                {
                    this.deleteCascadeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool deleteCascadeSpecified
            {
                get
                {
                    return this.deleteCascadeFieldSpecified;
                }
                set
                {
                    this.deleteCascadeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool deferrable
            {
                get
                {
                    return this.deferrableField;
                }
                set
                {
                    this.deferrableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool deferrableSpecified
            {
                get
                {
                    return this.deferrableFieldSpecified;
                }
                set
                {
                    this.deferrableFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool initiallyDeferred
            {
                get
                {
                    return this.initiallyDeferredField;
                }
                set
                {
                    this.initiallyDeferredField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool initiallyDeferredSpecified
            {
                get
                {
                    return this.initiallyDeferredFieldSpecified;
                }
                set
                {
                    this.initiallyDeferredFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetDropTable
        {

            private string schemaNameField;

            private string tableNameField;

            private bool cascadeConstraintsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool cascadeConstraints
            {
                get
                {
                    return this.cascadeConstraintsField;
                }
                set
                {
                    this.cascadeConstraintsField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetCreateView
        {

            private string schemaNameField;

            private string viewNameField;

            private bool replaceIfExistsField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string viewName
            {
                get
                {
                    return this.viewNameField;
                }
                set
                {
                    this.viewNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool replaceIfExists
            {
                get
                {
                    return this.replaceIfExistsField;
                }
                set
                {
                    this.replaceIfExistsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetRenameView
        {

            private string schemaNameField;

            private string oldViewNameField;

            private string newViewNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string oldViewName
            {
                get
                {
                    return this.oldViewNameField;
                }
                set
                {
                    this.oldViewNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string newViewName
            {
                get
                {
                    return this.newViewNameField;
                }
                set
                {
                    this.newViewNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetDropView
        {

            private string viewNameField;

            private string schemaNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string viewName
            {
                get
                {
                    return this.viewNameField;
                }
                set
                {
                    this.viewNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetInsert
        {

            private databaseChangeLogChangeSetInsertColumn columnField;

            private string schemaNameField;

            private string tableNameField;

            private string tablespaceField;

            /// <remarks/>
            public databaseChangeLogChangeSetInsertColumn column
            {
                get
                {
                    return this.columnField;
                }
                set
                {
                    this.columnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tablespace
            {
                get
                {
                    return this.tablespaceField;
                }
                set
                {
                    this.tablespaceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetInsertColumn
        {

            private databaseChangeLogChangeSetInsertColumnConstraints constraintsField;

            private string nameField;

            private string typeField;

            private string valueField;

            private string valueNumericField;

            private string valueBooleanField;

            private string valueDateField;

            private string defaultValueField;

            private string defaultValueNumericField;

            private string defaultValueDateField;

            private bool defaultValueBooleanField;

            private bool autoIncrementField;

            private string remarksField;

            /// <remarks/>
            public databaseChangeLogChangeSetInsertColumnConstraints constraints
            {
                get
                {
                    return this.constraintsField;
                }
                set
                {
                    this.constraintsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string valueNumeric
            {
                get
                {
                    return this.valueNumericField;
                }
                set
                {
                    this.valueNumericField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string valueBoolean
            {
                get
                {
                    return this.valueBooleanField;
                }
                set
                {
                    this.valueBooleanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string valueDate
            {
                get
                {
                    return this.valueDateField;
                }
                set
                {
                    this.valueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValue
            {
                get
                {
                    return this.defaultValueField;
                }
                set
                {
                    this.defaultValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValueNumeric
            {
                get
                {
                    return this.defaultValueNumericField;
                }
                set
                {
                    this.defaultValueNumericField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValueDate
            {
                get
                {
                    return this.defaultValueDateField;
                }
                set
                {
                    this.defaultValueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool defaultValueBoolean
            {
                get
                {
                    return this.defaultValueBooleanField;
                }
                set
                {
                    this.defaultValueBooleanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool autoIncrement
            {
                get
                {
                    return this.autoIncrementField;
                }
                set
                {
                    this.autoIncrementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string remarks
            {
                get
                {
                    return this.remarksField;
                }
                set
                {
                    this.remarksField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetInsertColumnConstraints
        {

            private bool nullableField;

            private bool primaryKeyField;

            private string primaryKeyNameField;

            private bool uniqueField;

            private string uniqueConstraintNameField;

            private string referencesField;

            private string foreignKeyNameField;

            private bool deleteCascadeField;

            private bool deferrableField;

            private bool initiallyDeferredField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool nullable
            {
                get
                {
                    return this.nullableField;
                }
                set
                {
                    this.nullableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool primaryKey
            {
                get
                {
                    return this.primaryKeyField;
                }
                set
                {
                    this.primaryKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string primaryKeyName
            {
                get
                {
                    return this.primaryKeyNameField;
                }
                set
                {
                    this.primaryKeyNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool unique
            {
                get
                {
                    return this.uniqueField;
                }
                set
                {
                    this.uniqueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string uniqueConstraintName
            {
                get
                {
                    return this.uniqueConstraintNameField;
                }
                set
                {
                    this.uniqueConstraintNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string references
            {
                get
                {
                    return this.referencesField;
                }
                set
                {
                    this.referencesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string foreignKeyName
            {
                get
                {
                    return this.foreignKeyNameField;
                }
                set
                {
                    this.foreignKeyNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool deleteCascade
            {
                get
                {
                    return this.deleteCascadeField;
                }
                set
                {
                    this.deleteCascadeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool deferrable
            {
                get
                {
                    return this.deferrableField;
                }
                set
                {
                    this.deferrableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool initiallyDeferred
            {
                get
                {
                    return this.initiallyDeferredField;
                }
                set
                {
                    this.initiallyDeferredField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetAddColumn
        {

            private databaseChangeLogChangeSetAddColumnColumn columnField;

            private string schemaNameField;

            private string tableNameField;

            private string tablespaceField;

            /// <remarks/>
            public databaseChangeLogChangeSetAddColumnColumn column
            {
                get
                {
                    return this.columnField;
                }
                set
                {
                    this.columnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tablespace
            {
                get
                {
                    return this.tablespaceField;
                }
                set
                {
                    this.tablespaceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetAddColumnColumn
        {

            private databaseChangeLogChangeSetAddColumnColumnConstraints constraintsField;

            private string nameField;

            private string typeField;

            private string valueField;

            private string valueNumericField;

            private string valueBooleanField;

            private string valueDateField;

            private string defaultValueField;

            private string defaultValueNumericField;

            private string defaultValueDateField;

            private bool defaultValueBooleanField;

            private bool defaultValueBooleanFieldSpecified;

            private bool autoIncrementField;

            private bool autoIncrementFieldSpecified;

            private string remarksField;

            /// <remarks/>
            public databaseChangeLogChangeSetAddColumnColumnConstraints constraints
            {
                get
                {
                    return this.constraintsField;
                }
                set
                {
                    this.constraintsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string valueNumeric
            {
                get
                {
                    return this.valueNumericField;
                }
                set
                {
                    this.valueNumericField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string valueBoolean
            {
                get
                {
                    return this.valueBooleanField;
                }
                set
                {
                    this.valueBooleanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string valueDate
            {
                get
                {
                    return this.valueDateField;
                }
                set
                {
                    this.valueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValue
            {
                get
                {
                    return this.defaultValueField;
                }
                set
                {
                    this.defaultValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValueNumeric
            {
                get
                {
                    return this.defaultValueNumericField;
                }
                set
                {
                    this.defaultValueNumericField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValueDate
            {
                get
                {
                    return this.defaultValueDateField;
                }
                set
                {
                    this.defaultValueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool defaultValueBoolean
            {
                get
                {
                    return this.defaultValueBooleanField;
                }
                set
                {
                    this.defaultValueBooleanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool defaultValueBooleanSpecified
            {
                get
                {
                    return this.defaultValueBooleanFieldSpecified;
                }
                set
                {
                    this.defaultValueBooleanFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool autoIncrement
            {
                get
                {
                    return this.autoIncrementField;
                }
                set
                {
                    this.autoIncrementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool autoIncrementSpecified
            {
                get
                {
                    return this.autoIncrementFieldSpecified;
                }
                set
                {
                    this.autoIncrementFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string remarks
            {
                get
                {
                    return this.remarksField;
                }
                set
                {
                    this.remarksField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetAddColumnColumnConstraints
        {

            private bool nullableField;

            private bool primaryKeyField;

            private string primaryKeyNameField;

            private bool uniqueField;

            private string uniqueConstraintNameField;

            private string referencesField;

            private string foreignKeyNameField;

            private bool deleteCascadeField;

            private bool deferrableField;

            private bool initiallyDeferredField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool nullable
            {
                get
                {
                    return this.nullableField;
                }
                set
                {
                    this.nullableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool primaryKey
            {
                get
                {
                    return this.primaryKeyField;
                }
                set
                {
                    this.primaryKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string primaryKeyName
            {
                get
                {
                    return this.primaryKeyNameField;
                }
                set
                {
                    this.primaryKeyNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool unique
            {
                get
                {
                    return this.uniqueField;
                }
                set
                {
                    this.uniqueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string uniqueConstraintName
            {
                get
                {
                    return this.uniqueConstraintNameField;
                }
                set
                {
                    this.uniqueConstraintNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string references
            {
                get
                {
                    return this.referencesField;
                }
                set
                {
                    this.referencesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string foreignKeyName
            {
                get
                {
                    return this.foreignKeyNameField;
                }
                set
                {
                    this.foreignKeyNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool deleteCascade
            {
                get
                {
                    return this.deleteCascadeField;
                }
                set
                {
                    this.deleteCascadeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool deferrable
            {
                get
                {
                    return this.deferrableField;
                }
                set
                {
                    this.deferrableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool initiallyDeferred
            {
                get
                {
                    return this.initiallyDeferredField;
                }
                set
                {
                    this.initiallyDeferredField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetSql
        {

            private string commentField;

            private string[] textField;

            private bool stripCommentsField;

            private bool stripCommentsFieldSpecified;

            private bool splitStatementsField;

            private bool splitStatementsFieldSpecified;

            private string endDelimiterField;

            /// <remarks/>
            public string comment
            {
                get
                {
                    return this.commentField;
                }
                set
                {
                    this.commentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool stripComments
            {
                get
                {
                    return this.stripCommentsField;
                }
                set
                {
                    this.stripCommentsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool stripCommentsSpecified
            {
                get
                {
                    return this.stripCommentsFieldSpecified;
                }
                set
                {
                    this.stripCommentsFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool splitStatements
            {
                get
                {
                    return this.splitStatementsField;
                }
                set
                {
                    this.splitStatementsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool splitStatementsSpecified
            {
                get
                {
                    return this.splitStatementsFieldSpecified;
                }
                set
                {
                    this.splitStatementsFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string endDelimiter
            {
                get
                {
                    return this.endDelimiterField;
                }
                set
                {
                    this.endDelimiterField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetCreateProcedure
        {

            private string commentField;

            /// <remarks/>
            public string comment
            {
                get
                {
                    return this.commentField;
                }
                set
                {
                    this.commentField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetSqlFile
        {

            private string pathField;

            private bool stripCommentsField;

            private bool splitStatementsField;

            private string encodingField;

            private string endDelimiterField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string path
            {
                get
                {
                    return this.pathField;
                }
                set
                {
                    this.pathField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool stripComments
            {
                get
                {
                    return this.stripCommentsField;
                }
                set
                {
                    this.stripCommentsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool splitStatements
            {
                get
                {
                    return this.splitStatementsField;
                }
                set
                {
                    this.splitStatementsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string encoding
            {
                get
                {
                    return this.encodingField;
                }
                set
                {
                    this.encodingField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string endDelimiter
            {
                get
                {
                    return this.endDelimiterField;
                }
                set
                {
                    this.endDelimiterField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetRenameTable
        {

            private string schemaNameField;

            private string oldTableNameField;

            private string newTableNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string oldTableName
            {
                get
                {
                    return this.oldTableNameField;
                }
                set
                {
                    this.oldTableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string newTableName
            {
                get
                {
                    return this.newTableNameField;
                }
                set
                {
                    this.newTableNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetRenameColumn
        {

            private string schemaNameField;

            private string tableNameField;

            private string tablespaceField;

            private string oldColumnNameField;

            private string newColumnNameField;

            private string columnDataTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tablespace
            {
                get
                {
                    return this.tablespaceField;
                }
                set
                {
                    this.tablespaceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string oldColumnName
            {
                get
                {
                    return this.oldColumnNameField;
                }
                set
                {
                    this.oldColumnNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string newColumnName
            {
                get
                {
                    return this.newColumnNameField;
                }
                set
                {
                    this.newColumnNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string columnDataType
            {
                get
                {
                    return this.columnDataTypeField;
                }
                set
                {
                    this.columnDataTypeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetDropColumn
        {

            private string schemaNameField;

            private string tableNameField;

            private string tablespaceField;

            private string columnNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tablespace
            {
                get
                {
                    return this.tablespaceField;
                }
                set
                {
                    this.tablespaceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string columnName
            {
                get
                {
                    return this.columnNameField;
                }
                set
                {
                    this.columnNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetModifyColumn
        {

            private databaseChangeLogChangeSetModifyColumnColumn columnField;

            private string schemaNameField;

            private string tableNameField;

            private string tablespaceField;

            /// <remarks/>
            public databaseChangeLogChangeSetModifyColumnColumn column
            {
                get
                {
                    return this.columnField;
                }
                set
                {
                    this.columnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tablespace
            {
                get
                {
                    return this.tablespaceField;
                }
                set
                {
                    this.tablespaceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetModifyColumnColumn
        {

            private databaseChangeLogChangeSetModifyColumnColumnConstraints constraintsField;

            private string nameField;

            private string typeField;

            private string valueField;

            private string valueNumericField;

            private string valueBooleanField;

            private string valueDateField;

            private string defaultValueField;

            private string defaultValueNumericField;

            private string defaultValueDateField;

            private bool defaultValueBooleanField;

            private bool defaultValueBooleanFieldSpecified;

            private bool autoIncrementField;

            private bool autoIncrementFieldSpecified;

            private string remarksField;

            /// <remarks/>
            public databaseChangeLogChangeSetModifyColumnColumnConstraints constraints
            {
                get
                {
                    return this.constraintsField;
                }
                set
                {
                    this.constraintsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string valueNumeric
            {
                get
                {
                    return this.valueNumericField;
                }
                set
                {
                    this.valueNumericField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string valueBoolean
            {
                get
                {
                    return this.valueBooleanField;
                }
                set
                {
                    this.valueBooleanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string valueDate
            {
                get
                {
                    return this.valueDateField;
                }
                set
                {
                    this.valueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValue
            {
                get
                {
                    return this.defaultValueField;
                }
                set
                {
                    this.defaultValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValueNumeric
            {
                get
                {
                    return this.defaultValueNumericField;
                }
                set
                {
                    this.defaultValueNumericField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValueDate
            {
                get
                {
                    return this.defaultValueDateField;
                }
                set
                {
                    this.defaultValueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool defaultValueBoolean
            {
                get
                {
                    return this.defaultValueBooleanField;
                }
                set
                {
                    this.defaultValueBooleanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool defaultValueBooleanSpecified
            {
                get
                {
                    return this.defaultValueBooleanFieldSpecified;
                }
                set
                {
                    this.defaultValueBooleanFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool autoIncrement
            {
                get
                {
                    return this.autoIncrementField;
                }
                set
                {
                    this.autoIncrementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool autoIncrementSpecified
            {
                get
                {
                    return this.autoIncrementFieldSpecified;
                }
                set
                {
                    this.autoIncrementFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string remarks
            {
                get
                {
                    return this.remarksField;
                }
                set
                {
                    this.remarksField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetModifyColumnColumnConstraints
        {

            private bool nullableField;

            private bool primaryKeyField;

            private string primaryKeyNameField;

            private bool uniqueField;

            private string uniqueConstraintNameField;

            private string referencesField;

            private string foreignKeyNameField;

            private bool deleteCascadeField;

            private bool deferrableField;

            private bool initiallyDeferredField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool nullable
            {
                get
                {
                    return this.nullableField;
                }
                set
                {
                    this.nullableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool primaryKey
            {
                get
                {
                    return this.primaryKeyField;
                }
                set
                {
                    this.primaryKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string primaryKeyName
            {
                get
                {
                    return this.primaryKeyNameField;
                }
                set
                {
                    this.primaryKeyNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool unique
            {
                get
                {
                    return this.uniqueField;
                }
                set
                {
                    this.uniqueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string uniqueConstraintName
            {
                get
                {
                    return this.uniqueConstraintNameField;
                }
                set
                {
                    this.uniqueConstraintNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string references
            {
                get
                {
                    return this.referencesField;
                }
                set
                {
                    this.referencesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string foreignKeyName
            {
                get
                {
                    return this.foreignKeyNameField;
                }
                set
                {
                    this.foreignKeyNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool deleteCascade
            {
                get
                {
                    return this.deleteCascadeField;
                }
                set
                {
                    this.deleteCascadeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool deferrable
            {
                get
                {
                    return this.deferrableField;
                }
                set
                {
                    this.deferrableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool initiallyDeferred
            {
                get
                {
                    return this.initiallyDeferredField;
                }
                set
                {
                    this.initiallyDeferredField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetMergeColumns
        {

            private string schemaNameField;

            private string tableNameField;

            private string tablespaceField;

            private string column1NameField;

            private string joinStringField;

            private string column2NameField;

            private string finalColumnNameField;

            private string finalColumnTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tablespace
            {
                get
                {
                    return this.tablespaceField;
                }
                set
                {
                    this.tablespaceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string column1Name
            {
                get
                {
                    return this.column1NameField;
                }
                set
                {
                    this.column1NameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string joinString
            {
                get
                {
                    return this.joinStringField;
                }
                set
                {
                    this.joinStringField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string column2Name
            {
                get
                {
                    return this.column2NameField;
                }
                set
                {
                    this.column2NameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string finalColumnName
            {
                get
                {
                    return this.finalColumnNameField;
                }
                set
                {
                    this.finalColumnNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string finalColumnType
            {
                get
                {
                    return this.finalColumnTypeField;
                }
                set
                {
                    this.finalColumnTypeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetCreateSequence
        {

            private string schemaNameField;

            private string sequenceNameField;

            private string startValueField;

            private string incrementByField;

            private string maxValueField;

            private string minValueField;

            private bool orderedField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string sequenceName
            {
                get
                {
                    return this.sequenceNameField;
                }
                set
                {
                    this.sequenceNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string startValue
            {
                get
                {
                    return this.startValueField;
                }
                set
                {
                    this.startValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string incrementBy
            {
                get
                {
                    return this.incrementByField;
                }
                set
                {
                    this.incrementByField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string maxValue
            {
                get
                {
                    return this.maxValueField;
                }
                set
                {
                    this.maxValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string minValue
            {
                get
                {
                    return this.minValueField;
                }
                set
                {
                    this.minValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool ordered
            {
                get
                {
                    return this.orderedField;
                }
                set
                {
                    this.orderedField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetAlterSequence
        {

            private string schemaNameField;

            private string sequenceNameField;

            private string startValueField;

            private string incrementByField;

            private string maxValueField;

            private string minValueField;

            private bool orderedField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string sequenceName
            {
                get
                {
                    return this.sequenceNameField;
                }
                set
                {
                    this.sequenceNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string startValue
            {
                get
                {
                    return this.startValueField;
                }
                set
                {
                    this.startValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string incrementBy
            {
                get
                {
                    return this.incrementByField;
                }
                set
                {
                    this.incrementByField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string maxValue
            {
                get
                {
                    return this.maxValueField;
                }
                set
                {
                    this.maxValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string minValue
            {
                get
                {
                    return this.minValueField;
                }
                set
                {
                    this.minValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool ordered
            {
                get
                {
                    return this.orderedField;
                }
                set
                {
                    this.orderedField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetDropSequence
        {

            private string schemaNameField;

            private string sequenceNameField;

            private string startValueField;

            private string incrementByField;

            private string maxValueField;

            private string minValueField;

            private bool orderedField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string sequenceName
            {
                get
                {
                    return this.sequenceNameField;
                }
                set
                {
                    this.sequenceNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string startValue
            {
                get
                {
                    return this.startValueField;
                }
                set
                {
                    this.startValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string incrementBy
            {
                get
                {
                    return this.incrementByField;
                }
                set
                {
                    this.incrementByField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string maxValue
            {
                get
                {
                    return this.maxValueField;
                }
                set
                {
                    this.maxValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string minValue
            {
                get
                {
                    return this.minValueField;
                }
                set
                {
                    this.minValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool ordered
            {
                get
                {
                    return this.orderedField;
                }
                set
                {
                    this.orderedField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetCreateIndex
        {

            private databaseChangeLogChangeSetCreateIndexColumn columnField;

            private string schemaNameField;

            private string tableNameField;

            private string tablespaceField;

            private string indexNameField;

            private bool uniqueField;

            private bool uniqueFieldSpecified;

            /// <remarks/>
            public databaseChangeLogChangeSetCreateIndexColumn column
            {
                get
                {
                    return this.columnField;
                }
                set
                {
                    this.columnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tablespace
            {
                get
                {
                    return this.tablespaceField;
                }
                set
                {
                    this.tablespaceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string indexName
            {
                get
                {
                    return this.indexNameField;
                }
                set
                {
                    this.indexNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool unique
            {
                get
                {
                    return this.uniqueField;
                }
                set
                {
                    this.uniqueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool uniqueSpecified
            {
                get
                {
                    return this.uniqueFieldSpecified;
                }
                set
                {
                    this.uniqueFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetCreateIndexColumn
        {

            private databaseChangeLogChangeSetCreateIndexColumnConstraints constraintsField;

            private string nameField;

            private string typeField;

            private string valueField;

            private string valueNumericField;

            private string valueBooleanField;

            private string valueDateField;

            private string defaultValueField;

            private string defaultValueNumericField;

            private string defaultValueDateField;

            private bool defaultValueBooleanField;

            private bool defaultValueBooleanFieldSpecified;

            private bool autoIncrementField;

            private bool autoIncrementFieldSpecified;

            private string remarksField;

            /// <remarks/>
            public databaseChangeLogChangeSetCreateIndexColumnConstraints constraints
            {
                get
                {
                    return this.constraintsField;
                }
                set
                {
                    this.constraintsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string valueNumeric
            {
                get
                {
                    return this.valueNumericField;
                }
                set
                {
                    this.valueNumericField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string valueBoolean
            {
                get
                {
                    return this.valueBooleanField;
                }
                set
                {
                    this.valueBooleanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string valueDate
            {
                get
                {
                    return this.valueDateField;
                }
                set
                {
                    this.valueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValue
            {
                get
                {
                    return this.defaultValueField;
                }
                set
                {
                    this.defaultValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValueNumeric
            {
                get
                {
                    return this.defaultValueNumericField;
                }
                set
                {
                    this.defaultValueNumericField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValueDate
            {
                get
                {
                    return this.defaultValueDateField;
                }
                set
                {
                    this.defaultValueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool defaultValueBoolean
            {
                get
                {
                    return this.defaultValueBooleanField;
                }
                set
                {
                    this.defaultValueBooleanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool defaultValueBooleanSpecified
            {
                get
                {
                    return this.defaultValueBooleanFieldSpecified;
                }
                set
                {
                    this.defaultValueBooleanFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool autoIncrement
            {
                get
                {
                    return this.autoIncrementField;
                }
                set
                {
                    this.autoIncrementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool autoIncrementSpecified
            {
                get
                {
                    return this.autoIncrementFieldSpecified;
                }
                set
                {
                    this.autoIncrementFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string remarks
            {
                get
                {
                    return this.remarksField;
                }
                set
                {
                    this.remarksField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetCreateIndexColumnConstraints
        {

            private bool nullableField;

            private bool primaryKeyField;

            private string primaryKeyNameField;

            private bool uniqueField;

            private string uniqueConstraintNameField;

            private string referencesField;

            private string foreignKeyNameField;

            private bool deleteCascadeField;

            private bool deferrableField;

            private bool initiallyDeferredField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool nullable
            {
                get
                {
                    return this.nullableField;
                }
                set
                {
                    this.nullableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool primaryKey
            {
                get
                {
                    return this.primaryKeyField;
                }
                set
                {
                    this.primaryKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string primaryKeyName
            {
                get
                {
                    return this.primaryKeyNameField;
                }
                set
                {
                    this.primaryKeyNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool unique
            {
                get
                {
                    return this.uniqueField;
                }
                set
                {
                    this.uniqueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string uniqueConstraintName
            {
                get
                {
                    return this.uniqueConstraintNameField;
                }
                set
                {
                    this.uniqueConstraintNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string references
            {
                get
                {
                    return this.referencesField;
                }
                set
                {
                    this.referencesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string foreignKeyName
            {
                get
                {
                    return this.foreignKeyNameField;
                }
                set
                {
                    this.foreignKeyNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool deleteCascade
            {
                get
                {
                    return this.deleteCascadeField;
                }
                set
                {
                    this.deleteCascadeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool deferrable
            {
                get
                {
                    return this.deferrableField;
                }
                set
                {
                    this.deferrableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool initiallyDeferred
            {
                get
                {
                    return this.initiallyDeferredField;
                }
                set
                {
                    this.initiallyDeferredField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetDropIndex
        {

            private string schemaNameField;

            private string tableNameField;

            private string tablespaceField;

            private string indexNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tablespace
            {
                get
                {
                    return this.tablespaceField;
                }
                set
                {
                    this.tablespaceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string indexName
            {
                get
                {
                    return this.indexNameField;
                }
                set
                {
                    this.indexNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetAddNotNullConstraint
        {

            private string schemaNameField;

            private string tableNameField;

            private string columnNameField;

            private string defaultNullValueField;

            private string columnDataTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string columnName
            {
                get
                {
                    return this.columnNameField;
                }
                set
                {
                    this.columnNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultNullValue
            {
                get
                {
                    return this.defaultNullValueField;
                }
                set
                {
                    this.defaultNullValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string columnDataType
            {
                get
                {
                    return this.columnDataTypeField;
                }
                set
                {
                    this.columnDataTypeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetDropNotNullConstraint
        {

            private string schemaNameField;

            private string tableNameField;

            private string columnNameField;

            private string columnDataTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string columnName
            {
                get
                {
                    return this.columnNameField;
                }
                set
                {
                    this.columnNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string columnDataType
            {
                get
                {
                    return this.columnDataTypeField;
                }
                set
                {
                    this.columnDataTypeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetAddForeignKeyConstraint
        {

            private string baseTableSchemaNameField;

            private string baseTableNameField;

            private string baseColumnNamesField;

            private string constraintNameField;

            private string referencedTableSchemaNameField;

            private string referencedTableNameField;

            private string referencedColumnNamesField;

            private bool deferrableField;

            private bool deferrableFieldSpecified;

            private bool initiallyDeferredField;

            private bool initiallyDeferredFieldSpecified;

            private bool deleteCascadeField;

            private bool deleteCascadeFieldSpecified;

            private string onDeleteField;

            private string onUpdateField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string baseTableSchemaName
            {
                get
                {
                    return this.baseTableSchemaNameField;
                }
                set
                {
                    this.baseTableSchemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string baseTableName
            {
                get
                {
                    return this.baseTableNameField;
                }
                set
                {
                    this.baseTableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string baseColumnNames
            {
                get
                {
                    return this.baseColumnNamesField;
                }
                set
                {
                    this.baseColumnNamesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string constraintName
            {
                get
                {
                    return this.constraintNameField;
                }
                set
                {
                    this.constraintNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string referencedTableSchemaName
            {
                get
                {
                    return this.referencedTableSchemaNameField;
                }
                set
                {
                    this.referencedTableSchemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string referencedTableName
            {
                get
                {
                    return this.referencedTableNameField;
                }
                set
                {
                    this.referencedTableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string referencedColumnNames
            {
                get
                {
                    return this.referencedColumnNamesField;
                }
                set
                {
                    this.referencedColumnNamesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool deferrable
            {
                get
                {
                    return this.deferrableField;
                }
                set
                {
                    this.deferrableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool deferrableSpecified
            {
                get
                {
                    return this.deferrableFieldSpecified;
                }
                set
                {
                    this.deferrableFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool initiallyDeferred
            {
                get
                {
                    return this.initiallyDeferredField;
                }
                set
                {
                    this.initiallyDeferredField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool initiallyDeferredSpecified
            {
                get
                {
                    return this.initiallyDeferredFieldSpecified;
                }
                set
                {
                    this.initiallyDeferredFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool deleteCascade
            {
                get
                {
                    return this.deleteCascadeField;
                }
                set
                {
                    this.deleteCascadeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool deleteCascadeSpecified
            {
                get
                {
                    return this.deleteCascadeFieldSpecified;
                }
                set
                {
                    this.deleteCascadeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string onDelete
            {
                get
                {
                    return this.onDeleteField;
                }
                set
                {
                    this.onDeleteField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string onUpdate
            {
                get
                {
                    return this.onUpdateField;
                }
                set
                {
                    this.onUpdateField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetDropForeignKeyConstraint
        {

            private string baseTableSchemaNameField;

            private string baseTableNameField;

            private string constraintNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string baseTableSchemaName
            {
                get
                {
                    return this.baseTableSchemaNameField;
                }
                set
                {
                    this.baseTableSchemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string baseTableName
            {
                get
                {
                    return this.baseTableNameField;
                }
                set
                {
                    this.baseTableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string constraintName
            {
                get
                {
                    return this.constraintNameField;
                }
                set
                {
                    this.constraintNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetDropAllForeignKeyConstraints
        {

            private string baseTableSchemaNameField;

            private string baseTableNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string baseTableSchemaName
            {
                get
                {
                    return this.baseTableSchemaNameField;
                }
                set
                {
                    this.baseTableSchemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string baseTableName
            {
                get
                {
                    return this.baseTableNameField;
                }
                set
                {
                    this.baseTableNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetAddPrimaryKey
        {

            private string schemaNameField;

            private string tableNameField;

            private string columnNamesField;

            private string constraintNameField;

            private string tablespaceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string columnNames
            {
                get
                {
                    return this.columnNamesField;
                }
                set
                {
                    this.columnNamesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string constraintName
            {
                get
                {
                    return this.constraintNameField;
                }
                set
                {
                    this.constraintNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tablespace
            {
                get
                {
                    return this.tablespaceField;
                }
                set
                {
                    this.tablespaceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetDropPrimaryKey
        {

            private string schemaNameField;

            private string tableNameField;

            private string constraintNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string constraintName
            {
                get
                {
                    return this.constraintNameField;
                }
                set
                {
                    this.constraintNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetAddLookupTable
        {

            private string existingTableSchemaNameField;

            private string existingTableNameField;

            private string existingColumnNameField;

            private string newTableSchemaNameField;

            private string newTableNameField;

            private string newColumnNameField;

            private string newColumnDataTypeField;

            private string constraintNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string existingTableSchemaName
            {
                get
                {
                    return this.existingTableSchemaNameField;
                }
                set
                {
                    this.existingTableSchemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string existingTableName
            {
                get
                {
                    return this.existingTableNameField;
                }
                set
                {
                    this.existingTableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string existingColumnName
            {
                get
                {
                    return this.existingColumnNameField;
                }
                set
                {
                    this.existingColumnNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string newTableSchemaName
            {
                get
                {
                    return this.newTableSchemaNameField;
                }
                set
                {
                    this.newTableSchemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string newTableName
            {
                get
                {
                    return this.newTableNameField;
                }
                set
                {
                    this.newTableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string newColumnName
            {
                get
                {
                    return this.newColumnNameField;
                }
                set
                {
                    this.newColumnNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string newColumnDataType
            {
                get
                {
                    return this.newColumnDataTypeField;
                }
                set
                {
                    this.newColumnDataTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string constraintName
            {
                get
                {
                    return this.constraintNameField;
                }
                set
                {
                    this.constraintNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetAddAutoIncrement
        {

            private string schemaNameField;

            private string tableNameField;

            private string columnNameField;

            private string columnDataTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string columnName
            {
                get
                {
                    return this.columnNameField;
                }
                set
                {
                    this.columnNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string columnDataType
            {
                get
                {
                    return this.columnDataTypeField;
                }
                set
                {
                    this.columnDataTypeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetAddDefaultValue
        {

            private string schemaNameField;

            private string tableNameField;

            private string columnNameField;

            private string defaultValueField;

            private string defaultValueNumericField;

            private string defaultValueDateField;

            private string defaultValueBooleanField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string columnName
            {
                get
                {
                    return this.columnNameField;
                }
                set
                {
                    this.columnNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValue
            {
                get
                {
                    return this.defaultValueField;
                }
                set
                {
                    this.defaultValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValueNumeric
            {
                get
                {
                    return this.defaultValueNumericField;
                }
                set
                {
                    this.defaultValueNumericField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValueDate
            {
                get
                {
                    return this.defaultValueDateField;
                }
                set
                {
                    this.defaultValueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValueBoolean
            {
                get
                {
                    return this.defaultValueBooleanField;
                }
                set
                {
                    this.defaultValueBooleanField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetDropDefaultValue
        {

            private string schemaNameField;

            private string tableNameField;

            private string columnNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string columnName
            {
                get
                {
                    return this.columnNameField;
                }
                set
                {
                    this.columnNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetAddUniqueConstraint
        {

            private string schemaNameField;

            private string tableNameField;

            private string columnNamesField;

            private string constraintNameField;

            private string tablespaceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string columnNames
            {
                get
                {
                    return this.columnNamesField;
                }
                set
                {
                    this.columnNamesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string constraintName
            {
                get
                {
                    return this.constraintNameField;
                }
                set
                {
                    this.constraintNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tablespace
            {
                get
                {
                    return this.tablespaceField;
                }
                set
                {
                    this.tablespaceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetDropUniqueConstraint
        {

            private string schemaNameField;

            private string tableNameField;

            private string constraintNameField;

            private string uniqueColumnsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string constraintName
            {
                get
                {
                    return this.constraintNameField;
                }
                set
                {
                    this.constraintNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string uniqueColumns
            {
                get
                {
                    return this.uniqueColumnsField;
                }
                set
                {
                    this.uniqueColumnsField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetCustomChange
        {

            private databaseChangeLogChangeSetCustomChangeParam paramField;

            private string classField;

            /// <remarks/>
            public databaseChangeLogChangeSetCustomChangeParam param
            {
                get
                {
                    return this.paramField;
                }
                set
                {
                    this.paramField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string @class
            {
                get
                {
                    return this.classField;
                }
                set
                {
                    this.classField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetCustomChangeParam
        {

            private string nameField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetUpdate
        {

            private databaseChangeLogChangeSetUpdateColumn columnField;

            private object whereField;

            private string schemaNameField;

            private string tableNameField;

            private string tablespaceField;

            /// <remarks/>
            public databaseChangeLogChangeSetUpdateColumn column
            {
                get
                {
                    return this.columnField;
                }
                set
                {
                    this.columnField = value;
                }
            }

            /// <remarks/>
            public object where
            {
                get
                {
                    return this.whereField;
                }
                set
                {
                    this.whereField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tablespace
            {
                get
                {
                    return this.tablespaceField;
                }
                set
                {
                    this.tablespaceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetUpdateColumn
        {

            private databaseChangeLogChangeSetUpdateColumnConstraints constraintsField;

            private string nameField;

            private string typeField;

            private string valueField;

            private string valueNumericField;

            private string valueBooleanField;

            private string valueDateField;

            private string defaultValueField;

            private string defaultValueNumericField;

            private string defaultValueDateField;

            private bool defaultValueBooleanField;

            private bool autoIncrementField;

            private string remarksField;

            /// <remarks/>
            public databaseChangeLogChangeSetUpdateColumnConstraints constraints
            {
                get
                {
                    return this.constraintsField;
                }
                set
                {
                    this.constraintsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string valueNumeric
            {
                get
                {
                    return this.valueNumericField;
                }
                set
                {
                    this.valueNumericField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string valueBoolean
            {
                get
                {
                    return this.valueBooleanField;
                }
                set
                {
                    this.valueBooleanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string valueDate
            {
                get
                {
                    return this.valueDateField;
                }
                set
                {
                    this.valueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValue
            {
                get
                {
                    return this.defaultValueField;
                }
                set
                {
                    this.defaultValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValueNumeric
            {
                get
                {
                    return this.defaultValueNumericField;
                }
                set
                {
                    this.defaultValueNumericField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValueDate
            {
                get
                {
                    return this.defaultValueDateField;
                }
                set
                {
                    this.defaultValueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool defaultValueBoolean
            {
                get
                {
                    return this.defaultValueBooleanField;
                }
                set
                {
                    this.defaultValueBooleanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool autoIncrement
            {
                get
                {
                    return this.autoIncrementField;
                }
                set
                {
                    this.autoIncrementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string remarks
            {
                get
                {
                    return this.remarksField;
                }
                set
                {
                    this.remarksField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetUpdateColumnConstraints
        {

            private bool nullableField;

            private bool primaryKeyField;

            private string primaryKeyNameField;

            private bool uniqueField;

            private string uniqueConstraintNameField;

            private string referencesField;

            private string foreignKeyNameField;

            private bool deleteCascadeField;

            private bool deferrableField;

            private bool initiallyDeferredField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool nullable
            {
                get
                {
                    return this.nullableField;
                }
                set
                {
                    this.nullableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool primaryKey
            {
                get
                {
                    return this.primaryKeyField;
                }
                set
                {
                    this.primaryKeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string primaryKeyName
            {
                get
                {
                    return this.primaryKeyNameField;
                }
                set
                {
                    this.primaryKeyNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool unique
            {
                get
                {
                    return this.uniqueField;
                }
                set
                {
                    this.uniqueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string uniqueConstraintName
            {
                get
                {
                    return this.uniqueConstraintNameField;
                }
                set
                {
                    this.uniqueConstraintNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string references
            {
                get
                {
                    return this.referencesField;
                }
                set
                {
                    this.referencesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string foreignKeyName
            {
                get
                {
                    return this.foreignKeyNameField;
                }
                set
                {
                    this.foreignKeyNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool deleteCascade
            {
                get
                {
                    return this.deleteCascadeField;
                }
                set
                {
                    this.deleteCascadeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool deferrable
            {
                get
                {
                    return this.deferrableField;
                }
                set
                {
                    this.deferrableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool initiallyDeferred
            {
                get
                {
                    return this.initiallyDeferredField;
                }
                set
                {
                    this.initiallyDeferredField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetDelete
        {

            private object whereField;

            private string schemaNameField;

            private string tableNameField;

            private string tablespaceField;

            /// <remarks/>
            public object where
            {
                get
                {
                    return this.whereField;
                }
                set
                {
                    this.whereField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tablespace
            {
                get
                {
                    return this.tablespaceField;
                }
                set
                {
                    this.tablespaceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetLoadData
        {

            private databaseChangeLogChangeSetLoadDataColumn columnField;

            private string schemaNameField;

            private string tableNameField;

            private string fileField;

            private string encodingField;

            /// <remarks/>
            public databaseChangeLogChangeSetLoadDataColumn column
            {
                get
                {
                    return this.columnField;
                }
                set
                {
                    this.columnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemaName
            {
                get
                {
                    return this.schemaNameField;
                }
                set
                {
                    this.schemaNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tableName
            {
                get
                {
                    return this.tableNameField;
                }
                set
                {
                    this.tableNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string file
            {
                get
                {
                    return this.fileField;
                }
                set
                {
                    this.fileField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string encoding
            {
                get
                {
                    return this.encodingField;
                }
                set
                {
                    this.encodingField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetLoadDataColumn
        {

            private ushort indexField;

            private string headerField;

            private string nameField;

            private string typeField;

            private string defaultValueField;

            private string defaultValueNumericField;

            private string defaultValueDateField;

            private bool defaultValueBooleanField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort index
            {
                get
                {
                    return this.indexField;
                }
                set
                {
                    this.indexField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string header
            {
                get
                {
                    return this.headerField;
                }
                set
                {
                    this.headerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValue
            {
                get
                {
                    return this.defaultValueField;
                }
                set
                {
                    this.defaultValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValueNumeric
            {
                get
                {
                    return this.defaultValueNumericField;
                }
                set
                {
                    this.defaultValueNumericField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultValueDate
            {
                get
                {
                    return this.defaultValueDateField;
                }
                set
                {
                    this.defaultValueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool defaultValueBoolean
            {
                get
                {
                    return this.defaultValueBooleanField;
                }
                set
                {
                    this.defaultValueBooleanField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetExecuteCommand
        {

            private databaseChangeLogChangeSetExecuteCommandArg argField;

            private string executableField;

            private string osField;

            /// <remarks/>
            public databaseChangeLogChangeSetExecuteCommandArg arg
            {
                get
                {
                    return this.argField;
                }
                set
                {
                    this.argField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string executable
            {
                get
                {
                    return this.executableField;
                }
                set
                {
                    this.executableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string os
            {
                get
                {
                    return this.osField;
                }
                set
                {
                    this.osField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetExecuteCommandArg
        {

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetRollback
        {

            private string changeSetPathField;

            private string changeSetAuthorField;

            private string changeSetIdField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string changeSetPath
            {
                get
                {
                    return this.changeSetPathField;
                }
                set
                {
                    this.changeSetPathField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string changeSetAuthor
            {
                get
                {
                    return this.changeSetAuthorField;
                }
                set
                {
                    this.changeSetAuthorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string changeSetId
            {
                get
                {
                    return this.changeSetIdField;
                }
                set
                {
                    this.changeSetIdField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogChangeSetModifySql
        {

            private string dbmsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string dbms
            {
                get
                {
                    return this.dbmsField;
                }
                set
                {
                    this.dbmsField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogInclude
        {

            private string fileField;

            private bool relativeToChangelogFileField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string file
            {
                get
                {
                    return this.fileField;
                }
                set
                {
                    this.fileField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool relativeToChangelogFile
            {
                get
                {
                    return this.relativeToChangelogFileField;
                }
                set
                {
                    this.relativeToChangelogFileField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class databaseChangeLogIncludeAll
        {

            private string pathField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string path
            {
                get
                {
                    return this.pathField;
                }
                set
                {
                    this.pathField = value;
                }
            }
        }


    }
}


   
