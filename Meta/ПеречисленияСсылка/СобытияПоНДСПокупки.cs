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
	public enum СобытияПоНДСПокупки
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"f6e04882-830b-4577-af6a-352fa8f752e3\", \"Представление\":\"ПредъявленНДСПоставщиком\"}")]
		ПредъявленНДСПоставщиком = 0,//Предъявлен НДСПоставщиком
	///<summary>
	///факт уплаты таможенного НДС при импорте товаров (по ГТД)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"695b9f6d-066c-4df8-826e-4af1b51946eb\", \"Представление\":\"УплаченНДСНаТаможне\"}")]
		УплаченНДСНаТаможне = 1,//Уплачен НДС на таможне
		[EnumMember(Value = "{\"Ссылка\":\"f9edb1d5-61c7-4c2f-984b-483b420ffd7f\", \"Представление\":\"ПолученСчетФактура\"}")]
		ПолученСчетФактура = 2,//Получен счет-фактура от поставщика
		[EnumMember(Value = "{\"Ссылка\":\"d4de17e0-d8ed-4773-b729-500ad4370391\", \"Представление\":\"НДСОплачен\"}")]
		НДСОплачен = 3,//НДС оплачен поставщику
	///<summary>
	///Событие обозначающее передачу ТМЦ на строительство основных средств
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"d1986075-d828-4e3a-9d41-371ab863a995\", \"Представление\":\"ПереданНДСНаСтроительство\"}")]
		ПереданНДСНаСтроительство = 4,//Передан НДС на строительство
	///<summary>
	///факт ввода ОС, к которому относится НДС, в эксплуатацию
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"03562d13-6a81-4445-9172-5664d0a21d34\", \"Представление\":\"ОСВведеноВЭксплуатацию\"}")]
		ОСВведеноВЭксплуатацию = 5,//ОС введено в эксплуатацию
	///<summary>
	///регистрируется факт включения НДС в стоимость приобретенной ценности
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"240d4ff8-869f-4fdf-9c13-1532ba22829b\", \"Представление\":\"НДСВключенВСтоимость\"}")]
		НДСВключенВСтоимость = 6,//НДС включен в стоимость
	///<summary>
	///для регистрации факта, что этот НДС связан с предполагаемым применения ставки НДС 0% при реализации и не подлежит вычету
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"05c75b1f-ca76-4339-b1b1-3a6fe4c4f11e\", \"Представление\":\"ПредполагаетсяСтавка0\"}")]
		ПредполагаетсяСтавка0 = 7,//Предполагается ставка 0%
		[EnumMember(Value = "{\"Ссылка\":\"e9d9f25b-405e-4222-b529-952453688afb\", \"Представление\":\"ПодтвержденаСтавка0\"}")]
		ПодтвержденаСтавка0 = 8,//Подтверждена ставка 0%
		[EnumMember(Value = "{\"Ссылка\":\"3b87cac6-e4fb-4af5-b7b9-ccd83a57283b\", \"Представление\":\"НеПодтвержденаСтавка0\"}")]
		НеПодтвержденаСтавка0 = 9,//Не подтверждена ставка 0%
		[EnumMember(Value = "{\"Ссылка\":\"a1b9c92e-6962-4476-a355-4f849ebc9ebc\", \"Представление\":\"ВосстановленНДС\"}")]
		ВосстановленНДС = 10,//Восстановлен НДС
		[EnumMember(Value = "{\"Ссылка\":\"ac895d1e-8fc6-41e2-8aa0-fc30bde68423\", \"Представление\":\"ПредъявленНДСКВычету\"}")]
		ПредъявленНДСКВычету = 11,//Предъявлен НДС к вычету
		[EnumMember(Value = "{\"Ссылка\":\"be8b473b-97ea-4ada-b494-0e5182fe3abc\", \"Представление\":\"ПредъявленНДСКВычету0\"}")]
		ПредъявленНДСКВычету0 = 12,//Предъявлен НДС к вычету 0%
		[EnumMember(Value = "{\"Ссылка\":\"87f9d4a1-7d0b-4011-b9f7-8db01956412d\", \"Представление\":\"Возврат\"}")]
		Возврат = 13,
		[EnumMember(Value = "{\"Ссылка\":\"57f5c585-aa31-4521-9b89-3a3b0ab8216f\", \"Представление\":\"НДСсписанНаРасходы\"}")]
		НДСсписанНаРасходы = 14,//НДС списан на расходы
	}
	public static partial class СобытияПоНДСПокупки_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПредъявленНДСПоставщиком = new Guid("2f356aaf-f7a8-e352-4577-830bf6e04882");//Предъявлен НДСПоставщиком
		///<summary>
		///факт уплаты таможенного НДС при импорте товаров (по ГТД)
		///</summary>
		public static readonly Guid УплаченНДСНаТаможне = new Guid("f14a6e82-19b5-eb46-4df8-066c695b9f6d");//Уплачен НДС на таможне
		public static readonly Guid ПолученСчетФактура = new Guid("3b484b98-0f42-7ffd-4c2f-61c7f9edb1d5");//Получен счет-фактура от поставщика
		public static readonly Guid НДСОплачен = new Guid("0a5029b7-37d4-9103-4773-d8edd4de17e0");//НДС оплачен поставщику
		///<summary>
		///Событие обозначающее передачу ТМЦ на строительство основных средств
		///</summary>
		public static readonly Guid ПереданНДСНаСтроительство = new Guid("1a37419d-63b8-95a9-4e3a-d828d1986075");//Передан НДС на строительство
		///<summary>
		///факт ввода ОС, к которому относится НДС, в эксплуатацию
		///</summary>
		public static readonly Guid ОСВведеноВЭксплуатацию = new Guid("64567291-a2d0-341d-4445-6a8103562d13");//ОС введено в эксплуатацию
		///<summary>
		///регистрируется факт включения НДС в стоимость приобретенной ценности
		///</summary>
		public static readonly Guid НДСВключенВСтоимость = new Guid("3215139c-22ba-9b82-4fdf-869f240d4ff8");//НДС включен в стоимость
		///<summary>
		///для регистрации факта, что этот НДС связан с предполагаемым применения ставки НДС 0% при реализации и не подлежит вычету
		///</summary>
		public static readonly Guid ПредполагаетсяСтавка0 = new Guid("6f3ab1b1-c4e4-1ef1-4339-ca7605c75b1f");//Предполагается ставка 0%
		public static readonly Guid ПодтвержденаСтавка0 = new Guid("249529b5-6853-fb8a-4222-405ee9d9f25b");//Подтверждена ставка 0%
		public static readonly Guid НеПодтвержденаСтавка0 = new Guid("d8ccb9b7-573a-3b28-4af5-e4fb3b87cac6");//Не подтверждена ставка 0%
		public static readonly Guid ВосстановленНДС = new Guid("844f55a3-bc9e-bc9e-4476-6962a1b9c92e");//Восстановлен НДС
		public static readonly Guid ПредъявленНДСКВычету = new Guid("30fca08a-e6bd-2384-41e2-8fc6ac895d1e");//Предъявлен НДС к вычету
		public static readonly Guid ПредъявленНДСКВычету0 = new Guid("510e94b4-fe82-bc3a-4ada-97eabe8b473b");//Предъявлен НДС к вычету 0%
		public static readonly Guid Возврат = new Guid("b08df7b9-5619-2d41-4011-7d0b87f9d4a1");
		public static readonly Guid НДСсписанНаРасходы = new Guid("3b3a899b-b80a-6f21-4521-aa3157f5c585");//НДС списан на расходы
		public static СобытияПоНДСПокупки Получить(this СобытияПоНДСПокупки Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СобытияПоНДСПокупки Получить(this СобытияПоНДСПокупки Значение, Guid Ссылка)
		{
			if(Ссылка == ПредъявленНДСПоставщиком)
			{
				return СобытияПоНДСПокупки.ПредъявленНДСПоставщиком;
			}
			else if(Ссылка == УплаченНДСНаТаможне)
			{
				return СобытияПоНДСПокупки.УплаченНДСНаТаможне;
			}
			else if(Ссылка == ПолученСчетФактура)
			{
				return СобытияПоНДСПокупки.ПолученСчетФактура;
			}
			else if(Ссылка == НДСОплачен)
			{
				return СобытияПоНДСПокупки.НДСОплачен;
			}
			else if(Ссылка == ПереданНДСНаСтроительство)
			{
				return СобытияПоНДСПокупки.ПереданНДСНаСтроительство;
			}
			else if(Ссылка == ОСВведеноВЭксплуатацию)
			{
				return СобытияПоНДСПокупки.ОСВведеноВЭксплуатацию;
			}
			else if(Ссылка == НДСВключенВСтоимость)
			{
				return СобытияПоНДСПокупки.НДСВключенВСтоимость;
			}
			else if(Ссылка == ПредполагаетсяСтавка0)
			{
				return СобытияПоНДСПокупки.ПредполагаетсяСтавка0;
			}
			else if(Ссылка == ПодтвержденаСтавка0)
			{
				return СобытияПоНДСПокупки.ПодтвержденаСтавка0;
			}
			else if(Ссылка == НеПодтвержденаСтавка0)
			{
				return СобытияПоНДСПокупки.НеПодтвержденаСтавка0;
			}
			else if(Ссылка == ВосстановленНДС)
			{
				return СобытияПоНДСПокупки.ВосстановленНДС;
			}
			else if(Ссылка == ПредъявленНДСКВычету)
			{
				return СобытияПоНДСПокупки.ПредъявленНДСКВычету;
			}
			else if(Ссылка == ПредъявленНДСКВычету0)
			{
				return СобытияПоНДСПокупки.ПредъявленНДСКВычету0;
			}
			else if(Ссылка == Возврат)
			{
				return СобытияПоНДСПокупки.Возврат;
			}
			else if(Ссылка == НДСсписанНаРасходы)
			{
				return СобытияПоНДСПокупки.НДСсписанНаРасходы;
			}
			return СобытияПоНДСПокупки.ПустаяСсылка;
		}
		public static byte[] Ключ(this СобытияПоНДСПокупки Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СобытияПоНДСПокупки Значение)
		{
			switch (Значение)
			{
				case СобытияПоНДСПокупки.ПредъявленНДСПоставщиком: return ПредъявленНДСПоставщиком;
				case СобытияПоНДСПокупки.УплаченНДСНаТаможне: return УплаченНДСНаТаможне;
				case СобытияПоНДСПокупки.ПолученСчетФактура: return ПолученСчетФактура;
				case СобытияПоНДСПокупки.НДСОплачен: return НДСОплачен;
				case СобытияПоНДСПокупки.ПереданНДСНаСтроительство: return ПереданНДСНаСтроительство;
				case СобытияПоНДСПокупки.ОСВведеноВЭксплуатацию: return ОСВведеноВЭксплуатацию;
				case СобытияПоНДСПокупки.НДСВключенВСтоимость: return НДСВключенВСтоимость;
				case СобытияПоНДСПокупки.ПредполагаетсяСтавка0: return ПредполагаетсяСтавка0;
				case СобытияПоНДСПокупки.ПодтвержденаСтавка0: return ПодтвержденаСтавка0;
				case СобытияПоНДСПокупки.НеПодтвержденаСтавка0: return НеПодтвержденаСтавка0;
				case СобытияПоНДСПокупки.ВосстановленНДС: return ВосстановленНДС;
				case СобытияПоНДСПокупки.ПредъявленНДСКВычету: return ПредъявленНДСКВычету;
				case СобытияПоНДСПокупки.ПредъявленНДСКВычету0: return ПредъявленНДСКВычету0;
				case СобытияПоНДСПокупки.Возврат: return Возврат;
				case СобытияПоНДСПокупки.НДСсписанНаРасходы: return НДСсписанНаРасходы;
			}
			return Guid.Empty;
		}
	}
}