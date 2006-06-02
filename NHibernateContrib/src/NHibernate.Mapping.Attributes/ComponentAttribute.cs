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
	
	
	/// <summary>Map properties of a child object to columns of the table of a parent class</summary>
	[System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct, AllowMultiple=true)]
	[System.Serializable()]
	public class ComponentAttribute : BaseAttribute
	{
		
		private bool _insertspecified;
		
		private bool _updatespecified;
		
		private bool _insert = true;
		
		private string _name = null;
		
		private string _class = null;
		
		private string _access = null;
		
		private bool _update = true;
		
		/// <summary> Default constructor (position=0) </summary>
		public ComponentAttribute() : 
				base(0)
		{
		}
		
		/// <summary> Constructor taking the position of the attribute. </summary>
		public ComponentAttribute(int position) : 
				base(position)
		{
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
		public virtual string Class
		{
			get
			{
				return this._class;
			}
			set
			{
				this._class = value;
			}
		}
		
		/// <summary> </summary>
		public virtual System.Type ClassType
		{
			get
			{
				return System.Type.GetType( this.Class );
			}
			set
			{
				if(value.Assembly == typeof(int).Assembly)
					this.Class = value.FullName.Substring(7);
				else
					this.Class = value.FullName + ", " + value.Assembly.GetName().Name;
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
	}
}
