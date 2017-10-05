﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:2.0.50727.5466
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
using System;
using FortnoxAPILibrary.Connectors;
using System.ComponentModel;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.1432.
// 

namespace FortnoxAPILibrary
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class Article
	{
		private string activeField;

		private string articleNumberField;

		private string bulkyField;

		private string constructionAccountField;

		private string depthField;

		private string descriptionField;

		private string disposableQuantityField;

		private string eANField;

		private string eUAccountField;

		private string eUVATAccountField;

		private string exportAccountField;

		private string heightField;

		private string houseworkField;

		private string manufacturerField;

		private string manufacturerArticleNumberField;

		private string noteField;

		private string purchaseAccountField;

		private string purchasePriceField;

		private string quantityInStockField;

		private string reservedQuantityField;

		private string salesAccountField;

		private string stockGoodsField;

		private string stockPlaceField;

		private string stockValueField;

		private string stockWarningField;

		private string supplierNameField;

		private string supplierNumberField;

		private ArticleConnector.ArticleType typeField;

		private string unitField;

		private string vATField;

		private string webshopArticleField;

		private string weightField;

		private string widthField;

		private string urlField;

	    private string salesPriceField;

		/// <remarks/>
		public string Active
		{
			get
			{
				return this.activeField;
			}
			set
			{
				this.activeField = value;
			}
		}

		/// <remarks/>
		public string ArticleNumber
		{
			get
			{
				return this.articleNumberField;
			}
			set
			{
				this.articleNumberField = value;
			}
		}

		/// <remarks/>
		public string Bulky
		{
			get
			{
				return this.bulkyField;
			}
			set
			{
				this.bulkyField = value;
			}
		}

		/// <remarks/>
		public string ConstructionAccount
		{
			get
			{
				return this.constructionAccountField;
			}
			set
			{
				this.constructionAccountField = value;
			}
		}

		/// <remarks/>
		public string Depth
		{
			get
			{
				return this.depthField;
			}
			set
			{
				this.depthField = value;
			}
		}

		/// <remarks/>
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[ReadOnly(true)]
		public string DisposableQuantity
		{
			get
			{
				return this.disposableQuantityField;
			}
			set
			{
				this.disposableQuantityField = value;
			}
		}

		/// <remarks/>
		public string EAN
		{
			get
			{
				return this.eANField;
			}
			set
			{
				this.eANField = value;
			}
		}

		/// <remarks/>
		public string EUAccount
		{
			get
			{
				return this.eUAccountField;
			}
			set
			{
				this.eUAccountField = value;
			}
		}

		/// <remarks/>
		public string EUVATAccount
		{
			get
			{
				return this.eUVATAccountField;
			}
			set
			{
				this.eUVATAccountField = value;
			}
		}


        /// <remarks/>
        public string Expired { get; set; }


		/// <remarks/>
		public string ExportAccount
		{
			get
			{
				return this.exportAccountField;
			}
			set
			{
				this.exportAccountField = value;
			}
		}

		/// <remarks/>
		public string Height
		{
			get
			{
				return this.heightField;
			}
			set
			{
				this.heightField = value;
			}
		}

		/// <remarks/>
		public string Housework
		{
			get
			{
				return this.houseworkField;
			}
			set
			{
				this.houseworkField = value;
			}
		}

        /// <remarks/>
        public string HouseWorkType { get; set; }


		/// <remarks/>
		public string Manufacturer
		{
			get
			{
				return this.manufacturerField;
			}
			set
			{
				this.manufacturerField = value;
			}
		}

		/// <remarks/>
		public string ManufacturerArticleNumber
		{
			get
			{
				return this.manufacturerArticleNumberField;
			}
			set
			{
				this.manufacturerArticleNumberField = value;
			}
		}

		/// <remarks/>
		public string Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}

		/// <remarks/>
		public string PurchaseAccount
		{
			get
			{
				return this.purchaseAccountField;
			}
			set
			{
				this.purchaseAccountField = value;
			}
		}

		/// <remarks/>
		public string PurchasePrice
		{
			get
			{
				return this.purchasePriceField;
			}
			set
			{
				this.purchasePriceField = value;
			}
		}

	    /// <remarks/>
	    [ReadOnly(true)]
	    public string SalesPrice
	    {
	        get
	        {
	            return salesPriceField;
	        }
	        set
	        {
	            salesPriceField = value;
	        }
	    }

	    /// <remarks/>
	    public string QuantityInStock
		{
			get
			{
				return this.quantityInStockField;
			}
			set
			{
				this.quantityInStockField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[ReadOnly(true)]
		public string ReservedQuantity
		{
			get
			{
				return this.reservedQuantityField;
			}
			set
			{
				this.reservedQuantityField = value;
			}
		}

		/// <remarks/>
		public string SalesAccount
		{
			get
			{
				return this.salesAccountField;
			}
			set
			{
				this.salesAccountField = value;
			}
		}

		/// <remarks/>
		public string StockGoods
		{
			get
			{
				return this.stockGoodsField;
			}
			set
			{
				this.stockGoodsField = value;
			}
		}

		/// <remarks/>
		public string StockPlace
		{
			get
			{
				return this.stockPlaceField;
			}
			set
			{
				this.stockPlaceField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[ReadOnly(true)]
		public string StockValue
		{
			get
			{
				return this.stockValueField;
			}
			set
			{
				this.stockValueField = value;
			}
		}

		/// <remarks/>
		public string StockWarning
		{
			get
			{
				return this.stockWarningField;
			}
			set
			{
				this.stockWarningField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string SupplierName
		{
			get
			{
				return this.supplierNameField;
			}
			set
			{
				this.supplierNameField = value;
			}
		}

		/// <remarks/>
		public string SupplierNumber
		{
			get
			{
				return this.supplierNumberField;
			}
			set
			{
				this.supplierNumberField = value;
			}
		}

		/// <remarks/>
		public ArticleConnector.ArticleType Type
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
		public string Unit
		{
			get
			{
				return this.unitField;
			}
			set
			{
				this.unitField = value;
			}
		}

		/// <remarks/>
		public string VAT
		{
			get
			{
				return this.vATField;
			}
			set
			{
				this.vATField = value;
			}
		}
		
		/// <remarks/>
		public string WebshopArticle
		{
			get
			{
				return this.webshopArticleField;
			}
			set
			{
				this.webshopArticleField = value;
			}
		}

		/// <remarks/>
		public string Weight
		{
			get
			{
				return this.weightField;
			}
			set
			{
				this.weightField = value;
			}
		}

		/// <remarks/>
		public string Width
		{
			get
			{
				return this.widthField;
			}
			set
			{
				this.widthField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[ReadOnly(true)]
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string url
		{
			get
			{
				return this.urlField;
			}
			set
			{
				this.urlField = value;
			}
		}
	}
}