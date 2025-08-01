﻿using Implem.DefinitionAccessor;
using Implem.Libraries.Classes;
using Implem.Libraries.DataSources.SqlServer;
using Implem.Libraries.Utilities;
using Implem.Pleasanter.Libraries.DataSources;
using Implem.Pleasanter.Libraries.DataTypes;
using Implem.Pleasanter.Libraries.Extensions;
using Implem.Pleasanter.Libraries.General;
using Implem.Pleasanter.Libraries.Html;
using Implem.Pleasanter.Libraries.HtmlParts;
using Implem.Pleasanter.Libraries.Models;
using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Responses;
using Implem.Pleasanter.Libraries.Security;
using Implem.Pleasanter.Libraries.Server;
using Implem.Pleasanter.Libraries.ServerScripts;
using Implem.Pleasanter.Libraries.Settings;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using static Implem.Pleasanter.Libraries.ServerScripts.ServerScriptModel;
namespace Implem.Pleasanter.Models
{
    [Serializable]
    public class BinaryModel : BaseModel
    {
        public long BinaryId = 0;
        public int TenantId = 0;
        public long ReferenceId = 0;
        public string Guid = string.Empty;
        public string BinaryType = string.Empty;
        public Title Title = new Title();
        public string Body = string.Empty;
        public byte[] Bin = null;
        public byte[] Thumbnail = null;
        public byte[] Icon = null;
        public string FileName = string.Empty;
        public string Extension = string.Empty;
        public long Size = 0;
        public string ContentType = string.Empty;
        public BinarySettings BinarySettings = new BinarySettings();
        public long SavedBinaryId = 0;
        public int SavedTenantId = 0;
        public long SavedReferenceId = 0;
        public string SavedGuid = string.Empty;
        public string SavedBinaryType = string.Empty;
        public string SavedTitle = string.Empty;
        public string SavedBody = string.Empty;
        public byte[] SavedBin = null;
        public byte[] SavedThumbnail = null;
        public byte[] SavedIcon = null;
        public string SavedFileName = string.Empty;
        public string SavedExtension = string.Empty;
        public long SavedSize = 0;
        public string SavedContentType = string.Empty;
        public string SavedBinarySettings = "{}";

        public bool BinaryId_Updated(Context context, bool copy = false, Column column = null)
        {
            if (copy && column?.CopyByDefault == true)
            {
                return column.GetDefaultInput(context: context).ToLong() != BinaryId;
            }
            return BinaryId != SavedBinaryId
                &&  (column == null
                    || column.DefaultInput.IsNullOrEmpty()
                    || column.GetDefaultInput(context: context).ToLong() != BinaryId);
        }

        public bool TenantId_Updated(Context context, bool copy = false, Column column = null)
        {
            if (copy && column?.CopyByDefault == true)
            {
                return column.GetDefaultInput(context: context).ToInt() != TenantId;
            }
            return TenantId != SavedTenantId
                &&  (column == null
                    || column.DefaultInput.IsNullOrEmpty()
                    || column.GetDefaultInput(context: context).ToInt() != TenantId);
        }

        public bool ReferenceId_Updated(Context context, bool copy = false, Column column = null)
        {
            if (copy && column?.CopyByDefault == true)
            {
                return column.GetDefaultInput(context: context).ToLong() != ReferenceId;
            }
            return ReferenceId != SavedReferenceId
                &&  (column == null
                    || column.DefaultInput.IsNullOrEmpty()
                    || column.GetDefaultInput(context: context).ToLong() != ReferenceId);
        }

        public bool Guid_Updated(Context context, bool copy = false, Column column = null)
        {
            if (copy && column?.CopyByDefault == true)
            {
                return column.GetDefaultInput(context: context).ToString() != Guid;
            }
            return Guid != SavedGuid && Guid != null
                &&  (column == null
                    || column.DefaultInput.IsNullOrEmpty()
                    || column.GetDefaultInput(context: context).ToString() != Guid);
        }

        public bool BinaryType_Updated(Context context, bool copy = false, Column column = null)
        {
            if (copy && column?.CopyByDefault == true)
            {
                return column.GetDefaultInput(context: context).ToString() != BinaryType;
            }
            return BinaryType != SavedBinaryType && BinaryType != null
                &&  (column == null
                    || column.DefaultInput.IsNullOrEmpty()
                    || column.GetDefaultInput(context: context).ToString() != BinaryType);
        }

        public bool Title_Updated(Context context, bool copy = false, Column column = null)
        {
            if (copy && column?.CopyByDefault == true)
            {
                return column.GetDefaultInput(context: context).ToString() != Title.Value;
            }
            return Title.Value != SavedTitle && Title.Value != null
                &&  (column == null
                    || column.DefaultInput.IsNullOrEmpty()
                    || column.GetDefaultInput(context: context).ToString() != Title.Value);
        }

        public bool Body_Updated(Context context, bool copy = false, Column column = null)
        {
            if (copy && column?.CopyByDefault == true)
            {
                return column.GetDefaultInput(context: context).ToString() != Body;
            }
            return Body != SavedBody && Body != null
                &&  (column == null
                    || column.DefaultInput.IsNullOrEmpty()
                    || column.GetDefaultInput(context: context).ToString() != Body);
        }

        public bool FileName_Updated(Context context, bool copy = false, Column column = null)
        {
            if (copy && column?.CopyByDefault == true)
            {
                return column.GetDefaultInput(context: context).ToString() != FileName;
            }
            return FileName != SavedFileName && FileName != null
                &&  (column == null
                    || column.DefaultInput.IsNullOrEmpty()
                    || column.GetDefaultInput(context: context).ToString() != FileName);
        }

        public bool Extension_Updated(Context context, bool copy = false, Column column = null)
        {
            if (copy && column?.CopyByDefault == true)
            {
                return column.GetDefaultInput(context: context).ToString() != Extension;
            }
            return Extension != SavedExtension && Extension != null
                &&  (column == null
                    || column.DefaultInput.IsNullOrEmpty()
                    || column.GetDefaultInput(context: context).ToString() != Extension);
        }

        public bool Size_Updated(Context context, bool copy = false, Column column = null)
        {
            if (copy && column?.CopyByDefault == true)
            {
                return column.GetDefaultInput(context: context).ToLong() != Size;
            }
            return Size != SavedSize
                &&  (column == null
                    || column.DefaultInput.IsNullOrEmpty()
                    || column.GetDefaultInput(context: context).ToLong() != Size);
        }

        public bool ContentType_Updated(Context context, bool copy = false, Column column = null)
        {
            if (copy && column?.CopyByDefault == true)
            {
                return column.GetDefaultInput(context: context).ToString() != ContentType;
            }
            return ContentType != SavedContentType && ContentType != null
                &&  (column == null
                    || column.DefaultInput.IsNullOrEmpty()
                    || column.GetDefaultInput(context: context).ToString() != ContentType);
        }

        public bool BinarySettings_Updated(Context context, bool copy = false, Column column = null)
        {
            if (copy && column?.CopyByDefault == true)
            {
                return column.GetDefaultInput(context: context).ToString() != BinarySettings.ToJson();
            }
            return BinarySettings.ToJson() != SavedBinarySettings && BinarySettings.ToJson() != null
                &&  (column == null
                    || column.DefaultInput.IsNullOrEmpty()
                    || column.GetDefaultInput(context: context).ToString() != BinarySettings.ToJson());
        }

        public bool Bin_Updated(Context context, bool copy = false, Column column = null)
        {
            return Bin != SavedBin && Bin != null;
        }

        public bool Thumbnail_Updated(Context context, bool copy = false, Column column = null)
        {
            return Thumbnail != SavedThumbnail && Thumbnail != null;
        }

        public bool Icon_Updated(Context context, bool copy = false, Column column = null)
        {
            return Icon != SavedIcon && Icon != null;
        }

        public BinarySettings Session_BinarySettings(Context context)
        {
            return context.SessionData.Get("BinarySettings") != null
                ? context.SessionData.Get("BinarySettings")?.ToString().Deserialize<BinarySettings>() ?? new BinarySettings()
                : BinarySettings;
        }

        public void Session_BinarySettings(Context context, string value)
        {
            string key = "BinarySettings";
            if (Parameters.Session.UseKeyValueStore && value == null)
            {
                string pageName = context.Page ?? string.Empty;
                StackExchange.Redis.IDatabase iDatabase = Implem.Pleasanter.Libraries.Redis.CacheForRedisConnection.Connection.GetDatabase();
                string fieldName = pageName.IsNullOrEmpty() ? $"{key}" : $"{key}_{pageName}";
                iDatabase.HashDelete(
                    context.SessionGuid,
                    fieldName);
            }
            else
            {
                SessionUtilities.Set(
                context: context,
                key: key,
                value: value,
                page: true);
            }
        }

        public BinaryModel()
        {
        }

        public BinaryModel(
            Context context,
            MethodTypes methodType = MethodTypes.NotSet)
        {
            OnConstructing(context: context);
            TenantId = context.TenantId;
            MethodType = methodType;
            OnConstructed(context: context);
        }

        public BinaryModel(
            Context context,
            long binaryId,
            SqlColumnCollection column = null,
            bool clearSessions = false,
            MethodTypes methodType = MethodTypes.NotSet)
        {
            OnConstructing(context: context);
            TenantId = context.TenantId;
            BinaryId = binaryId;
            if (context.QueryStrings.ContainsKey("ver"))
            {
                Get(
                    context: context,
                    tableType: Sqls.TableTypes.NormalAndHistory,
                    column: column,
                    where: Rds.BinariesWhereDefault(
                        context: context,
                        binaryModel: this)
                            .Binaries_Ver(context.QueryStrings.Int("ver")));
            }
            else
            {
                Get(
                    context: context,
                    column: column);
            }
            if (clearSessions) ClearSessions(context: context);
            MethodType = methodType;
            OnConstructed(context: context);
        }

        public BinaryModel(
            Context context,
            DataRow dataRow,
            string tableAlias = null)
        {
            OnConstructing(context: context);
            TenantId = context.TenantId;
            if (dataRow != null)
            {
                Set(
                    context: context,
                    dataRow: dataRow,
                    tableAlias: tableAlias);
            }
            OnConstructed(context: context);
        }

        private void OnConstructing(Context context)
        {
        }

        private void OnConstructed(Context context)
        {
        }

        public void ClearSessions(Context context)
        {
            Session_BinarySettings(context: context, value: null);
        }

        public BinaryModel Get(
            Context context,
            Sqls.TableTypes tableType = Sqls.TableTypes.Normal,
            SqlColumnCollection column = null,
            SqlJoinCollection join = null,
            SqlWhereCollection where = null,
            SqlOrderByCollection orderBy = null,
            SqlParamCollection param = null,
            bool distinct = false,
            int top = 0)
        {
            where = where ?? Rds.BinariesWhereDefault(
                context: context,
                binaryModel: this);
            column = (column ?? Rds.BinariesDefaultColumns());
            join = join ?? Rds.BinariesJoinDefault();
            Set(context, Repository.ExecuteTable(
                context: context,
                statements: Rds.SelectBinaries(
                    tableType: tableType,
                    column: column,
                    join: join,
                    where: where,
                    orderBy: orderBy,
                    param: param,
                    distinct: distinct,
                    top: top)));
            return this;
        }

        public ErrorData Create(
            Context context,
            SiteSettings ss,
            Sqls.TableTypes tableType = Sqls.TableTypes.Normal,
            SqlParamCollection param = null,
            string noticeType = "Created",
            bool otherInitValue = false,
            bool get = true)
        {
            TenantId = context.TenantId;
            Size = Bin.Length;
            var statements = new List<SqlStatement>();
            statements.AddRange(CreateStatements(
                context: context,
                ss: ss,
                tableType: tableType,
                param: param,
                otherInitValue: otherInitValue));
            var response = Repository.ExecuteScalar_response(
                context: context,
                transactional: true,
                selectIdentity: true,
                statements: statements.ToArray());
            BinaryId = (response.Id ?? BinaryId).ToLong();
            if (get) Get(context: context);
            return new ErrorData(type: Error.Types.None);
        }

        public List<SqlStatement> CreateStatements(
            Context context,
            SiteSettings ss,
            string dataTableName = null,
            Sqls.TableTypes tableType = Sqls.TableTypes.Normal,
            SqlParamCollection param = null,
            bool otherInitValue = false)
        {
            var statements = new List<SqlStatement>();
            statements.AddRange(new List<SqlStatement>
            {
                Rds.InsertBinaries(
                    dataTableName: dataTableName,
                    tableType: tableType,
                    selectIdentity: true,
                    param: param ?? Rds.BinariesParamDefault(
                        context: context,
                        ss: ss,
                        binaryModel: this,
                        setDefault: true,
                        otherInitValue: otherInitValue))
            });
            return statements;
        }

        public ErrorData Update(
            Context context,
            SiteSettings ss,
            SqlParamCollection param = null,
            List<SqlStatement> additionalStatements = null,
            bool otherInitValue = false,
            bool setBySession = true,
            bool get = true,
            bool checkConflict = true)
        {
            if (setBySession)
            {
                SetBySession(context: context);
            }
            var statements = new List<SqlStatement>();
            var verUp = Versions.VerUp(
                context: context,
                ss: ss,
                verUp: VerUp);
            statements.AddRange(UpdateStatements(
                context: context,
                ss: ss,
                param: param,
                otherInitValue: otherInitValue,
                additionalStatements: additionalStatements,
                checkConflict: checkConflict,
                verUp: verUp));
            var response = Repository.ExecuteScalar_response(
                context: context,
                transactional: true,
                statements: statements.ToArray());
            if (response.Event == "Conflicted")
            {
                return new ErrorData(
                    type: Error.Types.UpdateConflicts,
                    id: BinaryId);
            }
            if (get)
            {
                Get(context: context);
            }
            return new ErrorData(type: Error.Types.None);
        }

        public List<SqlStatement> UpdateStatements(
            Context context,
            SiteSettings ss,
            string dataTableName = null,
            SqlParamCollection param = null,
            bool otherInitValue = false,
            List<SqlStatement> additionalStatements = null,
            bool checkConflict = true,
            bool verUp = false)
        {
            var timestamp = Timestamp.ToDateTime();
            var statements = new List<SqlStatement>();
            var where = Rds.BinariesWhereDefault(
                context: context,
                binaryModel: this)
                    .UpdatedTime(timestamp, _using: timestamp.InRange() && checkConflict);
            if (verUp)
            {
                statements.Add(Rds.BinariesCopyToStatement(
                    where: where,
                    tableType: Sqls.TableTypes.History,
                    ColumnNames()));
                Ver++;
            }
            statements.AddRange(UpdateStatements(
                context: context,
                ss: ss,
                dataTableName: dataTableName,
                where: where,
                param: param,
                otherInitValue: otherInitValue));
            if (additionalStatements?.Any() == true)
            {
                statements.AddRange(additionalStatements);
            }
            return statements;
        }

        private List<SqlStatement> UpdateStatements(
            Context context,
            SiteSettings ss,
            string dataTableName = null,
            SqlWhereCollection where = null,
            SqlParamCollection param = null,
            bool otherInitValue = false)
        {
            return new List<SqlStatement>
            {
                Rds.UpdateBinaries(
                    dataTableName: dataTableName,
                    where: where,
                    param: param ?? Rds.BinariesParamDefault(
                        context: context,
                        ss: ss,
                        binaryModel: this,
                        otherInitValue: otherInitValue)),
                new SqlStatement()
                {
                    DataTableName = dataTableName,
                    IfConflicted = true,
                    Id = BinaryId
                }
            };
        }

        public ErrorData UpdateOrCreate(
            Context context,
            SiteSettings ss,
            string dataTableName = null,
            SqlWhereCollection where = null,
            SqlParamCollection param = null)
        {
            SetBySession(context: context);
            var statements = new List<SqlStatement>
            {
                Rds.UpdateOrInsertBinaries(
                    where: where ?? Rds.BinariesWhereDefault(
                        context: context,
                        binaryModel: this),
                    param: param ?? Rds.BinariesParamDefault(
                        context: context,
                        ss: ss,
                        binaryModel: this,
                        setDefault: true))
            };
            var response = Repository.ExecuteScalar_response(
                context: context,
                transactional: true,
                selectIdentity: true,
                statements: statements.ToArray());
            BinaryId = (response.Id ?? BinaryId).ToLong();
            Get(context: context);
            return new ErrorData(type: Error.Types.None);
        }

        public ErrorData Delete(Context context)
        {
            var statements = new List<SqlStatement>();
            var where = Rds.BinariesWhere().BinaryId(BinaryId);
            statements.AddRange(new List<SqlStatement>
            {
                Rds.DeleteBinaries(
                    factory: context,
                    where: where)
            });
            Repository.ExecuteNonQuery(
                context: context,
                transactional: true,
                statements: statements.ToArray());
            return new ErrorData(type: Error.Types.None);
        }

        public ErrorData Restore(Context context, long binaryId)
        {
            BinaryId = binaryId;
            Repository.ExecuteNonQuery(
                context: context,
                connectionString: Parameters.Rds.OwnerConnectionString,
                transactional: true,
                statements: new SqlStatement[]
                {
                    Rds.RestoreBinaries(
                        factory: context,
                        where: Rds.BinariesWhere().BinaryId(BinaryId))
                });
            return new ErrorData(type: Error.Types.None);
        }

        public ErrorData PhysicalDelete(
            Context context, Sqls.TableTypes tableType = Sqls.TableTypes.Normal)
        {
            Repository.ExecuteNonQuery(
                context: context,
                transactional: true,
                statements: Rds.PhysicalDeleteBinaries(
                    tableType: tableType,
                    where: Rds.BinariesWhere().BinaryId(BinaryId)));
            return new ErrorData(type: Error.Types.None);
        }

        public void SetByModel(BinaryModel binaryModel)
        {
            TenantId = binaryModel.TenantId;
            ReferenceId = binaryModel.ReferenceId;
            Guid = binaryModel.Guid;
            BinaryType = binaryModel.BinaryType;
            Title = binaryModel.Title;
            Body = binaryModel.Body;
            Bin = binaryModel.Bin;
            Thumbnail = binaryModel.Thumbnail;
            Icon = binaryModel.Icon;
            FileName = binaryModel.FileName;
            Extension = binaryModel.Extension;
            Size = binaryModel.Size;
            ContentType = binaryModel.ContentType;
            BinarySettings = binaryModel.BinarySettings;
            Comments = binaryModel.Comments;
            Creator = binaryModel.Creator;
            Updator = binaryModel.Updator;
            CreatedTime = binaryModel.CreatedTime;
            UpdatedTime = binaryModel.UpdatedTime;
            VerUp = binaryModel.VerUp;
            Comments = binaryModel.Comments;
            ClassHash = binaryModel.ClassHash;
            NumHash = binaryModel.NumHash;
            DateHash = binaryModel.DateHash;
            DescriptionHash = binaryModel.DescriptionHash;
            CheckHash = binaryModel.CheckHash;
            AttachmentsHash = binaryModel.AttachmentsHash;
        }

        private void SetBySession(Context context)
        {
            if (!context.Forms.Exists("Binaries_BinarySettings")) BinarySettings = Session_BinarySettings(context: context);
        }

        private void Set(Context context, DataTable dataTable)
        {
            switch (dataTable.Rows.Count)
            {
                case 1: Set(context, dataTable.Rows[0]); break;
                case 0: AccessStatus = Databases.AccessStatuses.NotFound; break;
                default: AccessStatus = Databases.AccessStatuses.Overlap; break;
            }
        }

        private void Set(Context context, DataRow dataRow, string tableAlias = null)
        {
            AccessStatus = Databases.AccessStatuses.Selected;
            foreach (DataColumn dataColumn in dataRow.Table.Columns)
            {
                var column = new ColumnNameInfo(dataColumn.ColumnName);
                if (column.TableAlias == tableAlias)
                {
                    switch (column.Name)
                    {
                        case "BinaryId":
                            if (dataRow[column.ColumnName] != DBNull.Value)
                            {
                                BinaryId = dataRow[column.ColumnName].ToLong();
                                SavedBinaryId = BinaryId;
                            }
                            break;
                        case "TenantId":
                            TenantId = dataRow[column.ColumnName].ToInt();
                            SavedTenantId = TenantId;
                            break;
                        case "ReferenceId":
                            ReferenceId = dataRow[column.ColumnName].ToLong();
                            SavedReferenceId = ReferenceId;
                            break;
                        case "Guid":
                            Guid = dataRow[column.ColumnName].ToString();
                            SavedGuid = Guid;
                            break;
                        case "Ver":
                            Ver = dataRow[column.ColumnName].ToInt();
                            SavedVer = Ver;
                            break;
                        case "BinaryType":
                            BinaryType = dataRow[column.ColumnName].ToString();
                            SavedBinaryType = BinaryType;
                            break;
                        case "Title":
                            Title = new Title(dataRow, "BinaryId");
                            SavedTitle = Title.Value;
                            break;
                        case "Body":
                            Body = dataRow[column.ColumnName].ToString();
                            SavedBody = Body;
                            break;
                        case "Bin":
                            Bin = dataRow.Bytes("Bin");
                            SavedBin = Bin;
                            break;
                        case "Thumbnail":
                            Thumbnail = dataRow.Bytes("Bin");
                            SavedThumbnail = Thumbnail;
                            break;
                        case "Icon":
                            Icon = dataRow.Bytes("Bin");
                            SavedIcon = Icon;
                            break;
                        case "FileName":
                            FileName = dataRow[column.ColumnName].ToString();
                            SavedFileName = FileName;
                            break;
                        case "Extension":
                            Extension = dataRow[column.ColumnName].ToString();
                            SavedExtension = Extension;
                            break;
                        case "Size":
                            Size = dataRow[column.ColumnName].ToLong();
                            SavedSize = Size;
                            break;
                        case "ContentType":
                            ContentType = dataRow[column.ColumnName].ToString();
                            SavedContentType = ContentType;
                            break;
                        case "BinarySettings":
                            BinarySettings = dataRow[column.ColumnName].ToString().Deserialize<BinarySettings>() ?? new BinarySettings();
                            SavedBinarySettings = BinarySettings.ToJson();
                            break;
                        case "Comments":
                            Comments = dataRow[column.ColumnName].ToString().Deserialize<Comments>() ?? new Comments();
                            SavedComments = Comments.ToJson();
                            break;
                        case "Creator":
                            Creator = SiteInfo.User(context: context, userId: dataRow.Int(column.ColumnName));
                            SavedCreator = Creator.Id;
                            break;
                        case "Updator":
                            Updator = SiteInfo.User(context: context, userId: dataRow.Int(column.ColumnName));
                            SavedUpdator = Updator.Id;
                            break;
                        case "CreatedTime":
                            CreatedTime = new Time(context, dataRow, column.ColumnName);
                            SavedCreatedTime = CreatedTime.Value;
                            break;
                        case "UpdatedTime":
                            UpdatedTime = new Time(context, dataRow, column.ColumnName); Timestamp = dataRow.Field<DateTime>(column.ColumnName).ToString("yyyy/M/d H:m:s.fff");
                            SavedUpdatedTime = UpdatedTime.Value;
                            break;
                        case "IsHistory":
                            VerType = dataRow.Bool(column.ColumnName)
                                ? Versions.VerTypes.History
                                : Versions.VerTypes.Latest; break;
                        default:
                            switch (Def.ExtendedColumnTypes.Get(column?.Name ?? string.Empty))
                            {
                                case "Class":
                                    SetClass(
                                        columnName: column.Name,
                                        value: dataRow[column.ColumnName].ToString());
                                    SetSavedClass(
                                        columnName: column.Name,
                                        value: GetClass(columnName: column.Name));
                                    break;
                                case "Num":
                                    SetNum(
                                        columnName: column.Name,
                                        value: new Num(
                                            dataRow: dataRow,
                                            name: column.ColumnName));
                                    SetSavedNum(
                                        columnName: column.Name,
                                        value: GetNum(columnName: column.Name).Value);
                                    break;
                                case "Date":
                                    SetDate(
                                        columnName: column.Name,
                                        value: dataRow[column.ColumnName].ToDateTime());
                                    SetSavedDate(
                                        columnName: column.Name,
                                        value: GetDate(columnName: column.Name));
                                    break;
                                case "Description":
                                    SetDescription(
                                        columnName: column.Name,
                                        value: dataRow[column.ColumnName].ToString());
                                    SetSavedDescription(
                                        columnName: column.Name,
                                        value: GetDescription(columnName: column.Name));
                                    break;
                                case "Check":
                                    SetCheck(
                                        columnName: column.Name,
                                        value: dataRow[column.ColumnName].ToBool());
                                    SetSavedCheck(
                                        columnName: column.Name,
                                        value: GetCheck(columnName: column.Name));
                                    break;
                                case "Attachments":
                                    SetAttachments(
                                        columnName: column.Name,
                                        value: dataRow[column.ColumnName].ToString()
                                            .Deserialize<Attachments>() ?? new Attachments());
                                    SetSavedAttachments(
                                        columnName: column.Name,
                                        value: GetAttachments(columnName: column.Name).ToJson());
                                    break;
                            }
                            break;
                    }
                }
            }
        }

        public bool Updated(Context context)
        {
            return Updated()
                || BinaryId_Updated(context: context)
                || TenantId_Updated(context: context)
                || ReferenceId_Updated(context: context)
                || Guid_Updated(context: context)
                || Ver_Updated(context: context)
                || BinaryType_Updated(context: context)
                || Title_Updated(context: context)
                || Body_Updated(context: context)
                || FileName_Updated(context: context)
                || Extension_Updated(context: context)
                || Size_Updated(context: context)
                || ContentType_Updated(context: context)
                || BinarySettings_Updated(context: context)
                || Comments_Updated(context: context)
                || Creator_Updated(context: context)
                || Updator_Updated(context: context);
        }

        private bool UpdatedWithColumn(Context context, SiteSettings ss)
        {
            return ClassHash.Any(o => Class_Updated(
                    columnName: o.Key,
                    column: ss.GetColumn(context: context, o.Key)))
                || NumHash.Any(o => Num_Updated(
                    columnName: o.Key,
                    column: ss.GetColumn(context: context, o.Key)))
                || DateHash.Any(o => Date_Updated(
                    columnName: o.Key,
                    column: ss.GetColumn(context: context, o.Key)))
                || DescriptionHash.Any(o => Description_Updated(
                    columnName: o.Key,
                    column: ss.GetColumn(context: context, o.Key)))
                || CheckHash.Any(o => Check_Updated(
                    columnName: o.Key,
                    column: ss.GetColumn(context: context, o.Key)))
                || AttachmentsHash.Any(o => Attachments_Updated(
                    columnName: o.Key,
                    column: ss.GetColumn(context: context, o.Key)));
        }

        public bool Updated(Context context, SiteSettings ss)
        {
            return UpdatedWithColumn(context: context, ss: ss)
                || BinaryId_Updated(context: context)
                || TenantId_Updated(context: context)
                || ReferenceId_Updated(context: context)
                || Guid_Updated(context: context)
                || Ver_Updated(context: context)
                || BinaryType_Updated(context: context)
                || Title_Updated(context: context)
                || Body_Updated(context: context)
                || FileName_Updated(context: context)
                || Extension_Updated(context: context)
                || Size_Updated(context: context)
                || ContentType_Updated(context: context)
                || BinarySettings_Updated(context: context)
                || Comments_Updated(context: context)
                || Creator_Updated(context: context)
                || Updator_Updated(context: context);
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public DateTime SiteImageUpdatedTime(
            Context context, Libraries.Images.ImageData.SizeTypes sizeType)
        {
            var updatedTime = DateTime.FromOADate(0);
            if (Parameters.BinaryStorage.GetSiteImageProvider() == "Local")
            {
                updatedTime = new Libraries.Images.ImageData(
                    ReferenceId, Libraries.Images.ImageData.Types.SiteImage)
                        .LastWriteTime(sizeType);
            }
            if (updatedTime == DateTime.FromOADate(0))
            {
                updatedTime = Repository.ExecuteScalar_datetime(
                    context: context,
                    statements: Rds.SelectBinaries(
                        column: Rds.BinariesColumn()
                            .UpdatedTime(function: Sqls.Functions.Max),
                        where: Rds.BinariesWhere()
                            .ReferenceId(ReferenceId)
                            .BinaryType("SiteImage")));
            }
            return updatedTime;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public DateTime TenantImageUpdatedTime(
            Context context, Libraries.Images.ImageData.SizeTypes sizeType)
        {
            var updatedTime = DateTime.FromOADate(0);
            if (Parameters.BinaryStorage.GetSiteImageProvider() == "Local")
            {
                updatedTime = new Libraries.Images.ImageData(
                    ReferenceId, Libraries.Images.ImageData.Types.TenantImage)
                        .LastWriteTime(sizeType);
            }
            if (updatedTime == DateTime.FromOADate(0))
            {
                updatedTime = Repository.ExecuteScalar_datetime(
                    context: context,
                    statements: Rds.SelectBinaries(
                        column: Rds.BinariesColumn()
                            .UpdatedTime(function: Sqls.Functions.Max),
                        where: Rds.BinariesWhere()
                            .ReferenceId(ReferenceId)
                            .BinaryType("TenantImage")));
            }
            return updatedTime;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public byte[] SiteImage(
            Context context,
            Libraries.Images.ImageData.SizeTypes sizeType,
            SqlColumnCollection column)
        {
            switch (Parameters.BinaryStorage.GetSiteImageProvider())
            {
                case "Local":
                    return new Libraries.Images.ImageData(
                        ReferenceId, Libraries.Images.ImageData.Types.SiteImage)
                            .Read(sizeType)
                                ?? SiteImage(
                                    context: context,
                                    column: column);
                default:
                    return SiteImage(
                        context: context,
                        column: column);
            }
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private byte[] SiteImage(Context context, SqlColumnCollection column)
        {
            return Repository.ExecuteScalar_bytes(
                context: context,
                statements: Rds.SelectBinaries(
                    column: column,
                    where: Rds.BinariesWhere()
                        .ReferenceId(ReferenceId)
                        .BinaryType("SiteImage")));
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public byte[] TenantImage(
            Context context,
            Libraries.Images.ImageData.SizeTypes sizeType,
            SqlColumnCollection column)
        {
            switch (Parameters.BinaryStorage.Provider)
            {
                case "Local":
                    return new Libraries.Images.ImageData(
                        ReferenceId, Libraries.Images.ImageData.Types.TenantImage)
                            .Read(sizeType)
                                ?? TenantImage(
                                    context: context,
                                    column: column);
                default:
                    return TenantImage(context, column);
            }
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private byte[] TenantImage(Context context, SqlColumnCollection column)
        {
            return Repository.ExecuteScalar_bytes(
                context: context,
                statements: Rds.SelectBinaries(
                    column: column,
                    where: Rds.BinariesWhere()
                        .ReferenceId(ReferenceId)
                        .BinaryType("TenantImage")));
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public Error.Types UpdateSiteImage(
            Context context,
            SiteSettings ss,
            byte[] bin)
        {
            BinaryType = "SiteImage";
            var imageData = new Libraries.Images.ImageData(
                bin,
                ReferenceId,
                Libraries.Images.ImageData.Types.SiteImage);
            switch (Parameters.BinaryStorage.GetSiteImageProvider())
            {
                case "Local": imageData.WriteToLocal(); break;
                default:
                    Bin = imageData.ReSizeBytes(Libraries.Images.ImageData.SizeTypes.Regular);
                    Thumbnail = imageData.ReSizeBytes(
                        Libraries.Images.ImageData.SizeTypes.Thumbnail);
                    Icon = imageData.ReSizeBytes(Libraries.Images.ImageData.SizeTypes.Icon);
                    ContentType = "image/png";
                    Repository.ExecuteNonQuery(
                        context: context,
                        transactional: true,
                        statements: Rds.UpdateOrInsertBinaries(
                            where: Rds.BinariesWhere()
                                .ReferenceId(ReferenceId)
                                .BinaryType("SiteImage"),
                            param: Rds.BinariesParamDefault(
                                context: context,
                                ss: ss,
                                binaryModel: this,
                                setDefault: true)));
                    break;
            }
            return Error.Types.None;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public Error.Types UpdateTenantImage(
            Context context,
            SiteSettings ss,
            byte[] bin)
        {
            BinaryType = "TenantImage";
            var imageData = new Libraries.Images.ImageData(
                bin,
                ReferenceId,
                Libraries.Images.ImageData.Types.TenantImage);
            switch (Parameters.BinaryStorage.Provider)
            {
                case "Local": imageData.WriteToLocal(); break;
                default:
                    Bin = imageData.ReSizeBytes(Libraries.Images.ImageData.SizeTypes.Logo);
                    ContentType = "image/png";
                    Repository.ExecuteNonQuery(
                        context: context,
                        transactional: true,
                        statements: Rds.UpdateOrInsertBinaries(
                            where: Rds.BinariesWhere()
                                .ReferenceId(ReferenceId)
                                .BinaryType("TenantImage"),
                            param: Rds.BinariesParamDefault(
                                context: context,
                                ss: ss,
                                binaryModel: this,
                                setDefault: true)));
                    break;
            }
            return Error.Types.None;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public Error.Types DeleteSiteImage(Context context)
        {
            BinaryType = "SiteImage";
            switch (Parameters.BinaryStorage.GetSiteImageProvider())
            {
                case "Local":
                    new Libraries.Images.ImageData(
                        ReferenceId,
                        Libraries.Images.ImageData.Types.SiteImage)
                            .DeleteLocalFiles();
                    break;
                default:
                    Repository.ExecuteNonQuery(
                        context: context,
                        statements: Rds.PhysicalDeleteBinaries(
                            where: Rds.BinariesWhere()
                                .ReferenceId(ReferenceId)
                                .BinaryType("SiteImage")));
                    break;
            }
            return Error.Types.None;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public Error.Types DeleteTenantImage(Context context)
        {
            BinaryType = "TenantImage";
            switch (Parameters.BinaryStorage.Provider)
            {
                case "Local":
                    new Libraries.Images.ImageData(
                        ReferenceId,
                        Libraries.Images.ImageData.Types.TenantImage)
                            .DeleteLocalFiles();
                    break;
                default:
                    Repository.ExecuteNonQuery(
                        context: context,
                        statements: Rds.PhysicalDeleteBinaries(
                            where: Rds.BinariesWhere()
                                .ReferenceId(ReferenceId)
                                .BinaryType("TenantImage")));
                    break;
            }
            return Error.Types.None;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public BinaryModel(long referenceId)
        {
            ReferenceId = referenceId;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public BinaryModel(Context context, long referenceId, string binaryType)
        {
            ReferenceId = referenceId;
            BinaryType = binaryType;
            if (Parameters.BinaryStorage.Provider == "Local")
            {
                return;
            }
            Get(
                context: context,
                where: Rds.BinariesWhere()
                    .ReferenceId(referenceId)
                    .BinaryType(binaryType),
                param: Rds.BinariesParam()
                    .ReferenceId()
                    .ContentType());
        }
    }
}
