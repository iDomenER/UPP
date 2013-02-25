﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Регл)
	///</summary>
	[DataContract]
	public enum СобытияПоНДСПродажи
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"a9b22cf0-abbb-4e21-a9a5-fe6c1888e801\", \"Представление\":\"ПолученАванс\"}")]
		ПолученАванс = 0,//Получен аванс
		[EnumMember(Value = "{\"Ссылка\":\"e646e025-5ebe-4237-b1db-30c1bad2d73c\", \"Представление\":\"Реализация\"}")]
		Реализация = 1,
		[EnumMember(Value = "{\"Ссылка\":\"b1ceb636-a2b0-4ebb-a1ab-4c86ec3dd311\", \"Представление\":\"НДСНачисленКУплате\"}")]
		НДСНачисленКУплате = 2,//НДС начислен к уплате
		[EnumMember(Value = "{\"Ссылка\":\"c8204731-2ec2-4ca5-ad26-a198c0ff1d99\", \"Представление\":\"ПодтвержденаСтавка0\"}")]
		ПодтвержденаСтавка0 = 3,//Подтверждена ставка 0%
		[EnumMember(Value = "{\"Ссылка\":\"112a0db6-50a6-464b-b9ac-563290846fd5\", \"Представление\":\"НеПодтвержденаСтавка0\"}")]
		НеПодтвержденаСтавка0 = 4,//Не подтверждена ставка 0%
		[EnumMember(Value = "{\"Ссылка\":\"1ffe7f9e-d538-472d-b41c-a269e51593d1\", \"Представление\":\"НДССкорректирован\"}")]
		НДССкорректирован = 5,//НДС скорректирован
		[EnumMember(Value = "{\"Ссылка\":\"03ecf2ab-9014-40da-845c-2fdbb126f2fb\", \"Представление\":\"Оплата\"}")]
		Оплата = 6,
		[EnumMember(Value = "{\"Ссылка\":\"551e015e-a864-43e7-9d4d-91aaf6e9dc85\", \"Представление\":\"ВосстановлениеНДС\"}")]
		ВосстановлениеНДС = 7,//Восстановление НДС
		[EnumMember(Value = "{\"Ссылка\":\"8a34f527-7601-4403-8a45-61a3ef098db1\", \"Представление\":\"НеПодтвержденаСтавка0Реализация\"}")]
		НеПодтвержденаСтавка0Реализация = 8,//Не подтверждена ставка 0% (реализация)
	}
	public static partial class СобытияПоНДСПродажи_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПолученАванс = new Guid("6cfea5a9-8818-01e8-4e21-abbba9b22cf0");//Получен аванс
		public static readonly Guid Реализация = new Guid("c130dbb1-d2ba-3cd7-4237-5ebee646e025");
		public static readonly Guid НДСНачисленКУплате = new Guid("864caba1-3dec-11d3-4ebb-a2b0b1ceb636");//НДС начислен к уплате
		public static readonly Guid ПодтвержденаСтавка0 = new Guid("98a126ad-ffc0-991d-4ca5-2ec2c8204731");//Подтверждена ставка 0%
		public static readonly Guid НеПодтвержденаСтавка0 = new Guid("3256acb9-8490-d56f-464b-50a6112a0db6");//Не подтверждена ставка 0%
		public static readonly Guid НДССкорректирован = new Guid("69a21cb4-15e5-d193-472d-d5381ffe7f9e");//НДС скорректирован
		public static readonly Guid Оплата = new Guid("db2f5c84-26b1-fbf2-40da-901403ecf2ab");
		public static readonly Guid ВосстановлениеНДС = new Guid("aa914d9d-e9f6-85dc-43e7-a864551e015e");//Восстановление НДС
		public static readonly Guid НеПодтвержденаСтавка0Реализация = new Guid("a361458a-09ef-b18d-4403-76018a34f527");//Не подтверждена ставка 0% (реализация)
		public static СобытияПоНДСПродажи Получить(this СобытияПоНДСПродажи Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СобытияПоНДСПродажи Получить(this СобытияПоНДСПродажи Значение, Guid Ссылка)
		{
			if(Ссылка == ПолученАванс)
			{
				return СобытияПоНДСПродажи.ПолученАванс;
			}
			else if(Ссылка == Реализация)
			{
				return СобытияПоНДСПродажи.Реализация;
			}
			else if(Ссылка == НДСНачисленКУплате)
			{
				return СобытияПоНДСПродажи.НДСНачисленКУплате;
			}
			else if(Ссылка == ПодтвержденаСтавка0)
			{
				return СобытияПоНДСПродажи.ПодтвержденаСтавка0;
			}
			else if(Ссылка == НеПодтвержденаСтавка0)
			{
				return СобытияПоНДСПродажи.НеПодтвержденаСтавка0;
			}
			else if(Ссылка == НДССкорректирован)
			{
				return СобытияПоНДСПродажи.НДССкорректирован;
			}
			else if(Ссылка == Оплата)
			{
				return СобытияПоНДСПродажи.Оплата;
			}
			else if(Ссылка == ВосстановлениеНДС)
			{
				return СобытияПоНДСПродажи.ВосстановлениеНДС;
			}
			else if(Ссылка == НеПодтвержденаСтавка0Реализация)
			{
				return СобытияПоНДСПродажи.НеПодтвержденаСтавка0Реализация;
			}
			return СобытияПоНДСПродажи.ПустаяСсылка;
		}
		public static byte[] Ключ(this СобытияПоНДСПродажи Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СобытияПоНДСПродажи Значение)
		{
			switch (Значение)
			{
				case СобытияПоНДСПродажи.ПолученАванс: return ПолученАванс;
				case СобытияПоНДСПродажи.Реализация: return Реализация;
				case СобытияПоНДСПродажи.НДСНачисленКУплате: return НДСНачисленКУплате;
				case СобытияПоНДСПродажи.ПодтвержденаСтавка0: return ПодтвержденаСтавка0;
				case СобытияПоНДСПродажи.НеПодтвержденаСтавка0: return НеПодтвержденаСтавка0;
				case СобытияПоНДСПродажи.НДССкорректирован: return НДССкорректирован;
				case СобытияПоНДСПродажи.Оплата: return Оплата;
				case СобытияПоНДСПродажи.ВосстановлениеНДС: return ВосстановлениеНДС;
				case СобытияПоНДСПродажи.НеПодтвержденаСтавка0Реализация: return НеПодтвержденаСтавка0Реализация;
			}
			return Guid.Empty;
		}
	}
}