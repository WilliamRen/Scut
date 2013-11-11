﻿//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由Codesmith工具生成。
// 此文件的更改可能会导致不正确的行为，如果
// 重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using ProtoBuf;
using ZyGames.Framework.Common;
using ZyGames.Framework.Collection;
using ZyGames.Framework.Model;


namespace ZyGames.Doudizhu.Model
{
    /// <summary>
    /// 
    /// </summary>
    /// <![CDATA[
    /// @periodTime:设置生存周期(秒)
    /// @personalName: 映射UserId对应的字段名,默认为"UserId"
    /// ]]>
    /// </remarks>
    [Serializable, ProtoContract]
	[EntityTable(AccessLevel.WriteOnly, DbConfig.Log, "UserItemLog")]
    public class UserItemLog : LogEntity
    {
        #region auto-generated static method
        static UserItemLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserItemLog));
        }
        #endregion
        /// <summary>
        /// </summary>
        public UserItemLog()
        {
            
        }        
        /// <summary>
        /// </summary>
        public UserItemLog(long iD)
            : this()
        {
            _iD = iD;
        }

        #region 自动生成属性
        private long _iD;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("ID", IsKey = true, IsIdentity = true)]
        public long ID
        {
            get
            {
                return _iD;
            } 
        }
        private int _uid;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("Uid")]
        public int Uid
        {
            set
            {
                SetChange("Uid", value);
            }
        }
        private string _userItemID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("UserItemID")]
        public string UserItemID
        {
            set
            {
                SetChange("UserItemID", value);
            }
        }
        private int _opType;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("OpType")]
        public int OpType
        {
            set
            {
                SetChange("OpType", value);
            }
        }
        private int _itemID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("ItemID")]
        public int ItemID
        {
            set
            {
                SetChange("ItemID", value);
            }
        }
        private int _num;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("Num")]
        public int Num
        {
            set
            {
                SetChange("Num", value);
            }
        }
        private DateTime _createDate;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("CreateDate")]
        public DateTime CreateDate
        {
            set
            {
                SetChange("CreateDate", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "ID": return _iD;
                    case "Uid": return _uid;
                    case "UserItemID": return _userItemID;
                    case "OpType": return _opType;
                    case "ItemID": return _itemID;
                    case "Num": return _num;
                    case "CreateDate": return _createDate;
					default: throw new ArgumentException(string.Format("UserItemLog index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "ID": 
                        _iD = MathUtils.ToLong(value);
                        break; 
                    case "Uid": 
                        _uid = value.ToInt();
                        break; 
                    case "UserItemID": 
                        _userItemID = value.ToNotNullString();
                        break; 
                    case "OpType": 
                        _opType = value.ToInt();
                        break; 
                    case "ItemID": 
                        _itemID = value.ToInt();
                        break; 
                    case "Num": 
                        _num = value.ToInt();
                        break; 
                    case "CreateDate": 
                        _createDate = value.ToDateTime();
                        break; 
					default: throw new ArgumentException(string.Format("UserItemLog index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion
        

	}
}