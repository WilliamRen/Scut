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
    [EntityTable(CacheType.Entity, DbConfig.Data, "UserTakePrize", Condition = "IsTasked=0")]
    public class UserTakePrize : ShareEntity
    {

        /// <summary>
        /// </summary>
        public UserTakePrize()
            : base(AccessLevel.ReadWrite)
        {
            
        }        
        /// <summary>
        /// </summary>
        public UserTakePrize(string iD)
            : this()
        {
            _iD = iD;
        }

        #region 自动生成属性
        private string _iD;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("ID", IsKey = true)]
        public string ID
        {
            get
            {
                return _iD;
			} 
			set
			{
				SetChange("ID", value);
			}
            
        }
        private int _userID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("UserID")]
        public int UserID
        {
            get
            {
                return _userID;
            } 
            set
            {
                SetChange("UserID", value);
            }
        }
        private int _gameCoin;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("GameCoin")]
        public int GameCoin
        {
            get
            {
                return _gameCoin;
            } 
            set
            {
                SetChange("GameCoin", value);
            }
        }
        private int _gold;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("Gold")]
        public int Gold
        {
            get
            {
                return _gold;
            } 
            set
            {
                SetChange("Gold", value);
            }
        }
        private string _itemPackage;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("ItemPackage")]
        public string ItemPackage
        {
            get
            {
                return _itemPackage;
            } 
            set
            {
                SetChange("ItemPackage", value);
            }
        }
        private string _mailContent;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("MailContent")]
        public string MailContent
        {
            get
            {
                return _mailContent;
            } 
            set
            {
                SetChange("MailContent", value);
            }
        }
        private bool _isTasked;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("IsTasked")]
        public bool IsTasked
        {
            get
            {
                return _isTasked;
            } 
            set
            {
                SetChange("IsTasked", value);
            }
        }
        private DateTime _taskDate;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("TaskDate")]
        public DateTime TaskDate
        {
            get
            {
                return _taskDate;
            } 
            set
            {
                SetChange("TaskDate", value);
            }
        }
        private int _opUserID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(9)]
        [EntityField("OpUserID")]
        public int OpUserID
        {
            get
            {
                return _opUserID;
            } 
            set
            {
                SetChange("OpUserID", value);
            }
        }
        private DateTime _createDate;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(10)]
        [EntityField("CreateDate")]
        public DateTime CreateDate
        {
            get
            {
                return _createDate;
            } 
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
                    case "UserID": return _userID;
                    case "GameCoin": return _gameCoin;
                    case "Gold": return _gold;
                    case "ItemPackage": return _itemPackage;
                    case "MailContent": return _mailContent;
                    case "IsTasked": return _isTasked;
                    case "TaskDate": return _taskDate;
                    case "OpUserID": return _opUserID;
                    case "CreateDate": return _createDate;
					default: throw new ArgumentException(string.Format("UserTakePrize index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "ID": 
                        _iD = value.ToNotNullString();
                        break; 
                    case "UserID": 
                        _userID = value.ToInt();
                        break; 
                    case "GameCoin": 
                        _gameCoin = value.ToInt();
                        break; 
                    case "Gold": 
                        _gold = value.ToInt();
                        break; 
                    case "ItemPackage": 
                        _itemPackage = value.ToNotNullString();
                        break; 
                    case "MailContent": 
                        _mailContent = value.ToNotNullString();
                        break; 
                    case "IsTasked": 
                        _isTasked = value.ToBool();
                        break; 
                    case "TaskDate": 
                        _taskDate = value.ToDateTime();
                        break; 
                    case "OpUserID": 
                        _opUserID = value.ToInt();
                        break; 
                    case "CreateDate": 
                        _createDate = value.ToDateTime();
                        break; 
					default: throw new ArgumentException(string.Format("UserTakePrize index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion
        
	}
}