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
	/// <summary>Class which represents the entity 'Document'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class Document : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="Document"/> class.</summary>
		public Document() : base()
		{
			this.ProductDocuments = new HashSet<ProductDocument>();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the ChangeNumber field. </summary>
		[DataMember]
		public System.Int32 ChangeNumber { get; set;}
		/// <summary>Gets or sets the DocumentLevel field. </summary>
		[DataMember]
		public Nullable<System.Int16> DocumentLevel { get; set;}
		/// <summary>Gets or sets the DocumentNode field. </summary>
		[DataMember]
		public System.String DocumentNode { get; set;}
		/// <summary>Gets or sets the DocumentSummary field. </summary>
		[DataMember]
		public System.String DocumentSummary { get; set;}
		/// <summary>Gets or sets the DocumentValue field. </summary>
		[DataMember]
		public System.Byte[] DocumentValue { get; set;}
		/// <summary>Gets or sets the FileExtension field. </summary>
		[DataMember]
		public System.String FileExtension { get; set;}
		/// <summary>Gets or sets the FileName field. </summary>
		[DataMember]
		public System.String FileName { get; set;}
		/// <summary>Gets or sets the FolderFlag field. </summary>
		[DataMember]
		public System.Boolean FolderFlag { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Revision field. </summary>
		[DataMember]
		public System.String Revision { get; set;}
		/// <summary>Gets or sets the Rowguid field. </summary>
		[DataMember]
		public System.Guid Rowguid { get; set;}
		/// <summary>Gets or sets the Status field. </summary>
		[DataMember]
		public System.Byte Status { get; set;}
		/// <summary>Gets or sets the Title field. </summary>
		[DataMember]
		public System.String Title { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Document.Employee - Employee.Documents (m:1)'</summary>
		[DataMember]
		public virtual Employee Employee { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductDocument.Document - Document.ProductDocuments (m:1)'</summary>
		[DataMember]
		public virtual ICollection<ProductDocument> ProductDocuments { get; set;}
		#endregion
	}
}