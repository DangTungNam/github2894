﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaaSAuthentication.Data
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SaaSAuthentication")]
	public partial class AuthenticationEntitiesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTenant(Tenant instance);
    partial void UpdateTenant(Tenant instance);
    partial void DeleteTenant(Tenant instance);
    partial void InsertUsersInTenant(UsersInTenant instance);
    partial void UpdateUsersInTenant(UsersInTenant instance);
    partial void DeleteUsersInTenant(UsersInTenant instance);
    #endregion
		
		public AuthenticationEntitiesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SaaSAuthenticationConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AuthenticationEntitiesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AuthenticationEntitiesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AuthenticationEntitiesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AuthenticationEntitiesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Tenant> Tenants
		{
			get
			{
				return this.GetTable<Tenant>();
			}
		}
		
		public System.Data.Linq.Table<UsersInTenant> UsersInTenants
		{
			get
			{
				return this.GetTable<UsersInTenant>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tenants")]
	public partial class Tenant : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _TenantId;
		
		private string _CompanyName;
		
		private string _CompanyUrl;
		
		private string _SubscriptionPlan;
		
		private EntitySet<UsersInTenant> _UsersInTenants;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTenantIdChanging(System.Guid value);
    partial void OnTenantIdChanged();
    partial void OnCompanyNameChanging(string value);
    partial void OnCompanyNameChanged();
    partial void OnCompanyUrlChanging(string value);
    partial void OnCompanyUrlChanged();
    partial void OnSubscriptionPlanChanging(string value);
    partial void OnSubscriptionPlanChanged();
    #endregion
		
		public Tenant()
		{
			this._UsersInTenants = new EntitySet<UsersInTenant>(new Action<UsersInTenant>(this.attach_UsersInTenants), new Action<UsersInTenant>(this.detach_UsersInTenants));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenantId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid TenantId
		{
			get
			{
				return this._TenantId;
			}
			set
			{
				if ((this._TenantId != value))
				{
					this.OnTenantIdChanging(value);
					this.SendPropertyChanging();
					this._TenantId = value;
					this.SendPropertyChanged("TenantId");
					this.OnTenantIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string CompanyName
		{
			get
			{
				return this._CompanyName;
			}
			set
			{
				if ((this._CompanyName != value))
				{
					this.OnCompanyNameChanging(value);
					this.SendPropertyChanging();
					this._CompanyName = value;
					this.SendPropertyChanged("CompanyName");
					this.OnCompanyNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyUrl", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string CompanyUrl
		{
			get
			{
				return this._CompanyUrl;
			}
			set
			{
				if ((this._CompanyUrl != value))
				{
					this.OnCompanyUrlChanging(value);
					this.SendPropertyChanging();
					this._CompanyUrl = value;
					this.SendPropertyChanged("CompanyUrl");
					this.OnCompanyUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubscriptionPlan", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SubscriptionPlan
		{
			get
			{
				return this._SubscriptionPlan;
			}
			set
			{
				if ((this._SubscriptionPlan != value))
				{
					this.OnSubscriptionPlanChanging(value);
					this.SendPropertyChanging();
					this._SubscriptionPlan = value;
					this.SendPropertyChanged("SubscriptionPlan");
					this.OnSubscriptionPlanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tenant_UsersInTenant", Storage="_UsersInTenants", ThisKey="TenantId", OtherKey="TenantId")]
		public EntitySet<UsersInTenant> UsersInTenants
		{
			get
			{
				return this._UsersInTenants;
			}
			set
			{
				this._UsersInTenants.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_UsersInTenants(UsersInTenant entity)
		{
			this.SendPropertyChanging();
			entity.Tenant = this;
		}
		
		private void detach_UsersInTenants(UsersInTenant entity)
		{
			this.SendPropertyChanging();
			entity.Tenant = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UsersInTenants")]
	public partial class UsersInTenant : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Guid _UserId;
		
		private System.Guid _TenantId;
		
		private EntityRef<Tenant> _Tenant;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUserIdChanging(System.Guid value);
    partial void OnUserIdChanged();
    partial void OnTenantIdChanging(System.Guid value);
    partial void OnTenantIdChanged();
    #endregion
		
		public UsersInTenant()
		{
			this._Tenant = default(EntityRef<Tenant>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenantId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid TenantId
		{
			get
			{
				return this._TenantId;
			}
			set
			{
				if ((this._TenantId != value))
				{
					if (this._Tenant.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTenantIdChanging(value);
					this.SendPropertyChanging();
					this._TenantId = value;
					this.SendPropertyChanged("TenantId");
					this.OnTenantIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tenant_UsersInTenant", Storage="_Tenant", ThisKey="TenantId", OtherKey="TenantId", IsForeignKey=true)]
		public Tenant Tenant
		{
			get
			{
				return this._Tenant.Entity;
			}
			set
			{
				Tenant previousValue = this._Tenant.Entity;
				if (((previousValue != value) 
							|| (this._Tenant.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tenant.Entity = null;
						previousValue.UsersInTenants.Remove(this);
					}
					this._Tenant.Entity = value;
					if ((value != null))
					{
						value.UsersInTenants.Add(this);
						this._TenantId = value.TenantId;
					}
					else
					{
						this._TenantId = default(System.Guid);
					}
					this.SendPropertyChanged("Tenant");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
