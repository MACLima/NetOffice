﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
    /// <summary>
    /// Interface IModel 
    /// SupportByVersion Excel, 15, 16
    /// </summary>
    [SupportByVersion("Excel", 15, 16)]
    [EntityType(EntityType.IsInterface)]
    public class IModel : COMObject, NetOffice.ExcelApi.IModel
    {
        #pragma warning disable

        #region Type Information

        /// <summary>        /// Instance Type
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type InstanceType
        {
            get
            {
                return LateBindingApiWrapperType;
            }
        }

        private static Type _type;

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IModel);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IModel() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual NetOffice.ExcelApi.Application Application
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlCreator Creator
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Excel", 15, 16), ProxyResult]
        public virtual object Parent
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual NetOffice.ExcelApi.ModelTables ModelTables
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ModelTables>(this, "ModelTables", typeof(NetOffice.ExcelApi.ModelTables));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual NetOffice.ExcelApi.ModelRelationships ModelRelationships
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ModelRelationships>(this, "ModelRelationships", typeof(NetOffice.ExcelApi.ModelRelationships));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual NetOffice.ExcelApi.WorkbookConnection DataModelConnection
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.WorkbookConnection>(this, "DataModelConnection", typeof(NetOffice.ExcelApi.WorkbookConnection));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual string Name
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Name");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual Int32 Refresh()
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Refresh");
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// </summary>
        /// <param name="connectionToDataSource">NetOffice.ExcelApi.WorkbookConnection connectionToDataSource</param>
        [SupportByVersion("Excel", 15, 16)]
        public virtual NetOffice.ExcelApi.WorkbookConnection AddConnection(NetOffice.ExcelApi.WorkbookConnection connectionToDataSource)
        {
            return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.WorkbookConnection>(this, "AddConnection", typeof(NetOffice.ExcelApi.WorkbookConnection), connectionToDataSource);
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// </summary>
        /// <param name="modelTable">object modelTable</param>
        [SupportByVersion("Excel", 15, 16)]
        public virtual NetOffice.ExcelApi.WorkbookConnection CreateModelWorkbookConnection(object modelTable)
        {
            return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.WorkbookConnection>(this, "CreateModelWorkbookConnection", typeof(NetOffice.ExcelApi.WorkbookConnection), modelTable);
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual Int32 Initialize()
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Initialize");
        }

        #endregion

        #pragma warning restore
    }
}

