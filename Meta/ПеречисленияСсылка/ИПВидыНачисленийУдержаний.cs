﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ИПВидыНачисленийУдержаний
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"4de67f2a-a59f-4fbb-b8ad-a1ce72ab00e5\", \"Представление\":\"НачисленоПовременно\"}")]
		НачисленоПовременно = 0,//Начислено повременно
		[EnumMember(Value = "{\"Ссылка\":\"9c9e6176-c639-462e-b795-6c53fbcfd6a1\", \"Представление\":\"НачисленоСдельно\"}")]
		НачисленоСдельно = 1,//Начислено сдельно
		[EnumMember(Value = "{\"Ссылка\":\"072f1cb0-5fc1-4a91-a0f9-587cc97a09e3\", \"Представление\":\"НачисленоДругое\"}")]
		НачисленоДругое = 2,//Начислено другое
		[EnumMember(Value = "{\"Ссылка\":\"7d8b79d2-fd7a-465c-9a4e-3461a7e713ba\", \"Представление\":\"НачисленоНатуральныйДоход\"}")]
		НачисленоНатуральныйДоход = 3,//Начислено натуральный доход
		[EnumMember(Value = "{\"Ссылка\":\"3a115a39-0927-44c6-9792-2254816b6565\", \"Представление\":\"УдержаноНДФЛ\"}")]
		УдержаноНДФЛ = 4,//Удержано НДФЛ
		[EnumMember(Value = "{\"Ссылка\":\"8e342efb-6203-4b1d-af18-9e566b4ab63a\", \"Представление\":\"УдержаноИсполнительныйЛист\"}")]
		УдержаноИсполнительныйЛист = 5,//Удержано исполнительный лист
		[EnumMember(Value = "{\"Ссылка\":\"70ca4292-41cb-46f7-9b54-2101f1d8d77e\", \"Представление\":\"УдержаноДругое\"}")]
		УдержаноДругое = 6,//Удержано другое
	}
	public static partial class ИПВидыНачисленийУдержаний_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid НачисленоПовременно = new Guid("cea1adb8-ab72-e500-4fbb-a59f4de67f2a");//Начислено повременно
		public static readonly Guid НачисленоСдельно = new Guid("536c95b7-cffb-a1d6-462e-c6399c9e6176");//Начислено сдельно
		public static readonly Guid НачисленоДругое = new Guid("7c58f9a0-7ac9-e309-4a91-5fc1072f1cb0");//Начислено другое
		public static readonly Guid НачисленоНатуральныйДоход = new Guid("61344e9a-e7a7-ba13-465c-fd7a7d8b79d2");//Начислено натуральный доход
		public static readonly Guid УдержаноНДФЛ = new Guid("54229297-6b81-6565-44c6-09273a115a39");//Удержано НДФЛ
		public static readonly Guid УдержаноИсполнительныйЛист = new Guid("569e18af-4a6b-3ab6-4b1d-62038e342efb");//Удержано исполнительный лист
		public static readonly Guid УдержаноДругое = new Guid("0121549b-d8f1-7ed7-46f7-41cb70ca4292");//Удержано другое
		public static ИПВидыНачисленийУдержаний Получить(this ИПВидыНачисленийУдержаний Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ИПВидыНачисленийУдержаний Получить(this ИПВидыНачисленийУдержаний Значение, Guid Ссылка)
		{
			if(Ссылка == НачисленоПовременно)
			{
				return ИПВидыНачисленийУдержаний.НачисленоПовременно;
			}
			else if(Ссылка == НачисленоСдельно)
			{
				return ИПВидыНачисленийУдержаний.НачисленоСдельно;
			}
			else if(Ссылка == НачисленоДругое)
			{
				return ИПВидыНачисленийУдержаний.НачисленоДругое;
			}
			else if(Ссылка == НачисленоНатуральныйДоход)
			{
				return ИПВидыНачисленийУдержаний.НачисленоНатуральныйДоход;
			}
			else if(Ссылка == УдержаноНДФЛ)
			{
				return ИПВидыНачисленийУдержаний.УдержаноНДФЛ;
			}
			else if(Ссылка == УдержаноИсполнительныйЛист)
			{
				return ИПВидыНачисленийУдержаний.УдержаноИсполнительныйЛист;
			}
			else if(Ссылка == УдержаноДругое)
			{
				return ИПВидыНачисленийУдержаний.УдержаноДругое;
			}
			return ИПВидыНачисленийУдержаний.ПустаяСсылка;
		}
		public static byte[] Ключ(this ИПВидыНачисленийУдержаний Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ИПВидыНачисленийУдержаний Значение)
		{
			switch (Значение)
			{
				case ИПВидыНачисленийУдержаний.НачисленоПовременно: return НачисленоПовременно;
				case ИПВидыНачисленийУдержаний.НачисленоСдельно: return НачисленоСдельно;
				case ИПВидыНачисленийУдержаний.НачисленоДругое: return НачисленоДругое;
				case ИПВидыНачисленийУдержаний.НачисленоНатуральныйДоход: return НачисленоНатуральныйДоход;
				case ИПВидыНачисленийУдержаний.УдержаноНДФЛ: return УдержаноНДФЛ;
				case ИПВидыНачисленийУдержаний.УдержаноИсполнительныйЛист: return УдержаноИсполнительныйЛист;
				case ИПВидыНачисленийУдержаний.УдержаноДругое: return УдержаноДругое;
			}
			return Guid.Empty;
		}
	}
}