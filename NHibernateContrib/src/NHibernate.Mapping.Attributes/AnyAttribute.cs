// 
// NHibernate.Mapping.Attributes
// This product is under the terms of the GNU Lesser General Public License.
//
//
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
//
//
// This source code was auto-generated by Refly, Version=2.21.1.0 (modified).
//
namespace NHibernate.Mapping.Attributes
{
	
	
	/// <summary> </summary>
	[System.AttributeUsage(System.AttributeTargets.Property | System.AttributeTargets.Field, AllowMultiple=true)]
	[System.Serializable()]
	public class AnyAttribute : BaseAttribute
	{
		
		private CascadeStyle _cascade = CascadeStyle.Unspecified;
		
		private bool _update = true;
		
		private string _metatype = null;
		
		private string _name = null;
		
		private bool _insert = true;
		
		private string _access = null;
		
		private bool _insertspecified;
		
		private string _index = null;
		
		private string _idtype = null;
		
		private bool _updatespecified;
		
		/// <summary> Default constructor (position=0) </summary>
		public AnyAttribute() : 
				base(0)
		{
		}
		
		/// <summary> Constructor taking the position of the attribute. </summary>
		public AnyAttribute(int position) : 
				base(position)
		{
		}
		
		/// <summary> </summary>
		public virtual string IdType
		{
			get
			{
				return this._idtype;
			}
			set
			{
				this._idtype = value;
			}
		}
		
		/// <summary> </summary>
		public virtual System.Type IdTypeType
		{
			get
			{
				return System.Type.GetType( this.IdType );
			}
			set
			{
				if(value.Assembly == typeof(int).Assembly)
					this.IdType = value.FullName.Substring(7);
				else
					this.IdType = value.FullName + ", " + value.Assembly.GetName().Name;
			}
		}
		
		/// <summary> </summary>
		public virtual string MetaType
		{
			get
			{
				return this._metatype;
			}
			set
			{
				this._metatype = value;
			}
		}
		
		/// <summary> </summary>
		public virtual System.Type MetaTypeType
		{
			get
			{
				return System.Type.GetType( this.MetaType );
			}
			set
			{
				if(value.Assembly == typeof(int).Assembly)
					this.MetaType = value.FullName.Substring(7);
				else
					this.MetaType = value.FullName + ", " + value.Assembly.GetName().Name;
			}
		}
		
		/// <summary> </summary>
		public virtual string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		
		/// <summary> </summary>
		public virtual string Access
		{
			get
			{
				return this._access;
			}
			set
			{
				this._access = value;
			}
		}
		
		/// <summary> </summary>
		public virtual System.Type AccessType
		{
			get
			{
				return System.Type.GetType( this.Access );
			}
			set
			{
				if(value.Assembly == typeof(int).Assembly)
					this.Access = value.FullName.Substring(7);
				else
					this.Access = value.FullName + ", " + value.Assembly.GetName().Name;
			}
		}
		
		/// <summary> </summary>
		public virtual bool Insert
		{
			get
			{
				return this._insert;
			}
			set
			{
				this._insert = value;
				_insertspecified = true;
			}
		}
		
		/// <summary> Tells if Insert has been specified. </summary>
		public virtual bool InsertSpecified
		{
			get
			{
				return this._insertspecified;
			}
		}
		
		/// <summary> </summary>
		public virtual bool Update
		{
			get
			{
				return this._update;
			}
			set
			{
				this._update = value;
				_updatespecified = true;
			}
		}
		
		/// <summary> Tells if Update has been specified. </summary>
		public virtual bool UpdateSpecified
		{
			get
			{
				return this._updatespecified;
			}
		}
		
		/// <summary> </summary>
		public virtual CascadeStyle Cascade
		{
			get
			{
				return this._cascade;
			}
			set
			{
				this._cascade = value;
			}
		}
		
		/// <summary> </summary>
		public virtual string Index
		{
			get
			{
				return this._index;
			}
			set
			{
				this._index = value;
			}
		}
	}
}
