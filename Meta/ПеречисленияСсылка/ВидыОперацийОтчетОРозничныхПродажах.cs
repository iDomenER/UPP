﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Общ)
	///</summary>
	[DataContract]
	public enum ВидыОперацийОтчетОРозничныхПродажах
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"21e89a2c-4fc1-42cb-9160-9828eaa12f1d\", \"Представление\":\"ОтчетККМОПродажах\"}")]
		ОтчетККМОПродажах = 0,//ККМ
		[EnumMember(Value = "{\"Ссылка\":\"0f48acd9-55cc-40f5-b88b-d60fb44791d9\", \"Представление\":\"ОтчетНТТОПродажах\"}")]
		ОтчетНТТОПродажах = 1,//НТТ
	}
	public static partial class ВидыОперацийОтчетОРозничныхПродажах_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ОтчетККМОПродажах = new Guid("28986091-a1ea-1d2f-42cb-4fc121e89a2c");//ККМ
		public static readonly Guid ОтчетНТТОПродажах = new Guid("0fd68bb8-47b4-d991-40f5-55cc0f48acd9");//НТТ
		public static ВидыОперацийОтчетОРозничныхПродажах Получить(this ВидыОперацийОтчетОРозничныхПродажах Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОперацийОтчетОРозничныхПродажах Получить(this ВидыОперацийОтчетОРозничныхПродажах Значение, Guid Ссылка)
		{
			if(Ссылка == ОтчетККМОПродажах)
			{
				return ВидыОперацийОтчетОРозничныхПродажах.ОтчетККМОПродажах;
			}
			else if(Ссылка == ОтчетНТТОПродажах)
			{
				return ВидыОперацийОтчетОРозничныхПродажах.ОтчетНТТОПродажах;
			}
			return ВидыОперацийОтчетОРозничныхПродажах.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОперацийОтчетОРозничныхПродажах Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОперацийОтчетОРозничныхПродажах Значение)
		{
			switch (Значение)
			{
				case ВидыОперацийОтчетОРозничныхПродажах.ОтчетККМОПродажах: return ОтчетККМОПродажах;
				case ВидыОперацийОтчетОРозничныхПродажах.ОтчетНТТОПродажах: return ОтчетНТТОПродажах;
			}
			return Guid.Empty;
		}
	}
}