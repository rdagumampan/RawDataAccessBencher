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
	/// <summary>Class which represents the entity 'ProductCategory'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class ProductCategory : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="ProductCategory"/> class.</summary>
		public ProductCategory() : base()
		{
			this.ProductSubcategories = new HashSet<ProductSubcategory>();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Name field. </summary>
		[DataMember]
		public System.String Name { get; set;}
		/// <summary>Gets or sets the ProductCategoryId field. </summary>
		[DataMember]
		public System.Int32 ProductCategoryId { get; set;}
		/// <summary>Gets or sets the Rowguid field. </summary>
		[DataMember]
		public System.Guid Rowguid { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductSubcategory.ProductCategory - ProductCategory.ProductSubcategories (m:1)'</summary>
		[DataMember]
		public virtual ICollection<ProductSubcategory> ProductSubcategories { get; set;}
		#endregion
	}
}
