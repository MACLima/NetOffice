﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;

namespace NetOffice.VisioApi
{
	/// <summary>
	/// DispatchInterface IVMenuSets 
	/// SupportByVersion Visio, 11,12,14,15,16
	/// </summary>
	[SupportByVersion("Visio", 11,12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface), BaseType, Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Property, "Item")]
	[TypeId("000D0236-0000-0000-C000-000000000046")]
    [CoClassSource(typeof(NetOffice.VisioApi.MenuSets))]
    public interface IVMenuSets : ICOMObject, IEnumerableProvider<NetOffice.VisioApi.IVMenuSet>
	{
		#region Properties

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <param name="lIndex">Int32 lIndex</param>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		[BaseResult]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		NetOffice.VisioApi.IVMenuSet this[Int32 lIndex] { get; }

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <param name="lID">Int32 lID</param>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		NetOffice.VisioApi.IVMenuSet get_ItemAtID(Int32 lID);

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Alias for get_ItemAtID
		/// </summary>
		/// <param name="lID">Int32 lID</param>
		[SupportByVersion("Visio", 11,12,14,15,16), Redirect("get_ItemAtID")]
		NetOffice.VisioApi.IVMenuSet ItemAtID(Int32 lID);

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		Int32 Count { get; }

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		[BaseResult]
		NetOffice.VisioApi.IVUIObject Parent { get; }

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		[BaseResult]
		NetOffice.VisioApi.IVMenuSet Add();

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="lID">Int32 lID</param>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		[BaseResult]
		NetOffice.VisioApi.IVMenuSet AddAtID(Int32 lID);

		#endregion
	}
}
