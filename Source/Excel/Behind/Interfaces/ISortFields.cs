﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// Interface ISortFields 
	/// SupportByVersion Excel, 12,14,15,16
	/// </summary>	[SupportByVersion("Excel", 12,14,15,16)]
	[EntityType(EntityType.IsInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Property, "_Default")]
	public class ISortFields : COMObject, NetOffice.ExcelApi.ISortFields
	{
		#pragma warning disable

		#region Type Information

        /// <summary>
        /// Instance Type        /// </summary>
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
                    _type = typeof(ISortFields);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public ISortFields() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.Application Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Excel", 12,14,15,16), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual Int32 Count
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Count");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Excel", 12,14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public virtual NetOffice.ExcelApi.SortField this[object index]
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.SortField>(this, "_Default", typeof(NetOffice.ExcelApi.SortField), index);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <param name="key">NetOffice.ExcelApi.Range key</param>
		/// <param name="sortOn">optional object sortOn</param>
		/// <param name="order">optional object order</param>
		/// <param name="customOrder">optional object customOrder</param>
		/// <param name="dataOption">optional object dataOption</param>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.SortField Add(NetOffice.ExcelApi.Range key, object sortOn, object order, object customOrder, object dataOption)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.SortField>(this, "Add", typeof(NetOffice.ExcelApi.SortField), new object[]{ key, sortOn, order, customOrder, dataOption });
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <param name="key">NetOffice.ExcelApi.Range key</param>
		[CustomMethod]
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.SortField Add(NetOffice.ExcelApi.Range key)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.SortField>(this, "Add", typeof(NetOffice.ExcelApi.SortField), key);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <param name="key">NetOffice.ExcelApi.Range key</param>
		/// <param name="sortOn">optional object sortOn</param>
		[CustomMethod]
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.SortField Add(NetOffice.ExcelApi.Range key, object sortOn)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.SortField>(this, "Add", typeof(NetOffice.ExcelApi.SortField), key, sortOn);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <param name="key">NetOffice.ExcelApi.Range key</param>
		/// <param name="sortOn">optional object sortOn</param>
		/// <param name="order">optional object order</param>
		[CustomMethod]
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.SortField Add(NetOffice.ExcelApi.Range key, object sortOn, object order)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.SortField>(this, "Add", typeof(NetOffice.ExcelApi.SortField), key, sortOn, order);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <param name="key">NetOffice.ExcelApi.Range key</param>
		/// <param name="sortOn">optional object sortOn</param>
		/// <param name="order">optional object order</param>
		/// <param name="customOrder">optional object customOrder</param>
		[CustomMethod]
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.SortField Add(NetOffice.ExcelApi.Range key, object sortOn, object order, object customOrder)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.SortField>(this, "Add", typeof(NetOffice.ExcelApi.SortField), key, sortOn, order, customOrder);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual Int32 Clear()
		{
			return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Clear");
		}

        #endregion

        #region IEnumerableProvider<NetOffice.ExcelApi.SortField>

        ICOMObject IEnumerableProvider<NetOffice.ExcelApi.SortField>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsProperty(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.ExcelApi.SortField>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, false);
        }

        #endregion

        #region IEnumerable<NetOffice.ExcelApi.SortField>

        /// <summary>
        /// SupportByVersion Excel, 12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual IEnumerator<NetOffice.ExcelApi.SortField> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.ExcelApi.SortField item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion Excel, 12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 12,14,15,16)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this, false);
		}

		#endregion

		#pragma warning restore
	}
}

