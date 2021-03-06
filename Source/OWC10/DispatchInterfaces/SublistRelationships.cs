﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;

namespace NetOffice.OWC10Api
{
	/// <summary>
	/// DispatchInterface SublistRelationships 
	/// SupportByVersion OWC10, 1
	/// </summary>
	[SupportByVersion("OWC10", 1)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Property, "Item")]
	[TypeId("F5B39AE1-1480-11D3-8549-00C04FAC67D7")]
	public interface SublistRelationships : ICOMObject, IEnumerableProvider<NetOffice.OWC10Api.PageRelationship>
	{
		#region Properties

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		Int32 Count { get; }

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("OWC10", 1)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		NetOffice.OWC10Api.PageRelationship this[object index] { get; }

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		/// <param name="pageRowsource">NetOffice.OWC10Api.PageRowsource pageRowsource</param>
		/// <param name="schemaRelationship">NetOffice.OWC10Api.SchemaRelationship schemaRelationship</param>
		[SupportByVersion("OWC10", 1)]
		NetOffice.OWC10Api.PageRelationship Add(NetOffice.OWC10Api.PageRowsource pageRowsource, NetOffice.OWC10Api.SchemaRelationship schemaRelationship);

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("OWC10", 1)]
		void Delete(object index);

		#endregion
	}
}
