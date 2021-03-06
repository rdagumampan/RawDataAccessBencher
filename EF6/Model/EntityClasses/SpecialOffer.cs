﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace EF6.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'SpecialOffer'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class SpecialOffer : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="SpecialOffer"/> class.</summary>
		public SpecialOffer() : base()
		{
			this.SpecialOfferProducts = new HashSet<SpecialOfferProduct>();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the Category field. </summary>
		[DataMember]
		public System.String Category { get; set;}
		/// <summary>Gets or sets the Description field. </summary>
		[DataMember]
		public System.String Description { get; set;}
		/// <summary>Gets or sets the DiscountPct field. </summary>
		[DataMember]
		public System.Decimal DiscountPct { get; set;}
		/// <summary>Gets or sets the EndDate field. </summary>
		[DataMember]
		public System.DateTime EndDate { get; set;}
		/// <summary>Gets or sets the MaxQty field. </summary>
		[DataMember]
		public Nullable<System.Int32> MaxQty { get; set;}
		/// <summary>Gets or sets the MinQty field. </summary>
		[DataMember]
		public System.Int32 MinQty { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Rowguid field. </summary>
		[DataMember]
		public System.Guid Rowguid { get; set;}
		/// <summary>Gets or sets the SpecialOfferId field. </summary>
		[DataMember]
		public System.Int32 SpecialOfferId { get; set;}
		/// <summary>Gets or sets the StartDate field. </summary>
		[DataMember]
		public System.DateTime StartDate { get; set;}
		/// <summary>Gets or sets the Type field. </summary>
		[DataMember]
		public System.String Type { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'SpecialOfferProduct.SpecialOffer - SpecialOffer.SpecialOfferProducts (m:1)'</summary>
		[DataMember]
		public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set;}
		#endregion
	}
}
