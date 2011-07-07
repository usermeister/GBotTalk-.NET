﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GTalk_Reminder_Bot
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ReminderDB")]
	public partial class ReminderDBClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTask(Task instance);
    partial void UpdateTask(Task instance);
    partial void DeleteTask(Task instance);
    #endregion
		
		public ReminderDBClassDataContext() : 
				base(global::GTalk_Reminder_Bot.Properties.Settings.Default.ReminderDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ReminderDBClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ReminderDBClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ReminderDBClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ReminderDBClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Task> Tasks
		{
			get
			{
				return this.GetTable<Task>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tasks")]
	public partial class Task : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _taskID;
		
		private string _title;
		
		private string _message;
		
		private System.DateTime _startTime;
		
		private System.DateTime _endTime;
		
		private string _interval;
		
		private string _recipients;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntaskIDChanging(int value);
    partial void OntaskIDChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OnmessageChanging(string value);
    partial void OnmessageChanged();
    partial void OnstartTimeChanging(System.DateTime value);
    partial void OnstartTimeChanged();
    partial void OnendTimeChanging(System.DateTime value);
    partial void OnendTimeChanged();
    partial void OnintervalChanging(string value);
    partial void OnintervalChanged();
    partial void OnrecipientsChanging(string value);
    partial void OnrecipientsChanged();
    #endregion
		
		public Task()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_taskID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int taskID
		{
			get
			{
				return this._taskID;
			}
			set
			{
				if ((this._taskID != value))
				{
					this.OntaskIDChanging(value);
					this.SendPropertyChanging();
					this._taskID = value;
					this.SendPropertyChanged("taskID");
					this.OntaskIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_message", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string message
		{
			get
			{
				return this._message;
			}
			set
			{
				if ((this._message != value))
				{
					this.OnmessageChanging(value);
					this.SendPropertyChanging();
					this._message = value;
					this.SendPropertyChanged("message");
					this.OnmessageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_startTime", DbType="DateTime NOT NULL")]
		public System.DateTime startTime
		{
			get
			{
				return this._startTime;
			}
			set
			{
				if ((this._startTime != value))
				{
					this.OnstartTimeChanging(value);
					this.SendPropertyChanging();
					this._startTime = value;
					this.SendPropertyChanged("startTime");
					this.OnstartTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_endTime", DbType="DateTime NOT NULL")]
		public System.DateTime endTime
		{
			get
			{
				return this._endTime;
			}
			set
			{
				if ((this._endTime != value))
				{
					this.OnendTimeChanging(value);
					this.SendPropertyChanging();
					this._endTime = value;
					this.SendPropertyChanged("endTime");
					this.OnendTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_interval", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string interval
		{
			get
			{
				return this._interval;
			}
			set
			{
				if ((this._interval != value))
				{
					this.OnintervalChanging(value);
					this.SendPropertyChanging();
					this._interval = value;
					this.SendPropertyChanged("interval");
					this.OnintervalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_recipients", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string recipients
		{
			get
			{
				return this._recipients;
			}
			set
			{
				if ((this._recipients != value))
				{
					this.OnrecipientsChanging(value);
					this.SendPropertyChanging();
					this._recipients = value;
					this.SendPropertyChanged("recipients");
					this.OnrecipientsChanged();
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
