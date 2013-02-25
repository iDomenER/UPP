﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(упр)
	///</summary>
	[DataContract]
	public enum ВидыОперацийПланируемоеПоступлениеДС
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"3edea177-dbe1-41e9-85f2-8ef2568a3156\", \"Представление\":\"ОплатаПокупателя\"}")]
		ОплатаПокупателя = 0,//Оплата от покупателя
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"48979ea5-f27b-437d-95c1-7831e8e7b537\", \"Представление\":\"ВозвратДенежныхСредствПоставщиком\"}")]
		ВозвратДенежныхСредствПоставщиком = 1,//Возврат денежных средств поставщиком
		[EnumMember(Value = "{\"Ссылка\":\"dcfa3348-fda1-459c-ad36-813ed2221e49\", \"Представление\":\"РасчетыПоКредитамИЗаймам\"}")]
		РасчетыПоКредитамИЗаймам = 2,//Расчеты по кредитам и займам
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"e245b282-8c04-43d2-8166-5713db2e3cd9\", \"Представление\":\"ПриходДенежныхСредствРозничнаяВыручка\"}")]
		ПриходДенежныхСредствРозничнаяВыручка = 3,//Прием розничной выручки
		[EnumMember(Value = "{\"Ссылка\":\"6f620796-be8f-42e2-815a-249d065dd925\", \"Представление\":\"ПрочееПоступлениеДенежныхСредств\"}")]
		ПрочееПоступлениеДенежныхСредств = 4,//Прочее поступление денежных средств
		[EnumMember(Value = "{\"Ссылка\":\"9cb0c8b9-5747-4505-a740-4a0999ed0892\", \"Представление\":\"ПрочиеРасчетыСКонтрагентами\"}")]
		ПрочиеРасчетыСКонтрагентами = 5,//Прочие расчеты с контрагентами
	}
	public static partial class ВидыОперацийПланируемоеПоступлениеДС_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ОплатаПокупателя = new Guid("f28ef285-8a56-5631-41e9-dbe13edea177");//Оплата от покупателя
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВозвратДенежныхСредствПоставщиком = new Guid("3178c195-e7e8-37b5-437d-f27b48979ea5");//Возврат денежных средств поставщиком
		public static readonly Guid РасчетыПоКредитамИЗаймам = new Guid("3e8136ad-22d2-491e-459c-fda1dcfa3348");//Расчеты по кредитам и займам
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПриходДенежныхСредствРозничнаяВыручка = new Guid("13576681-2edb-d93c-43d2-8c04e245b282");//Прием розничной выручки
		public static readonly Guid ПрочееПоступлениеДенежныхСредств = new Guid("9d245a81-5d06-25d9-42e2-be8f6f620796");//Прочее поступление денежных средств
		public static readonly Guid ПрочиеРасчетыСКонтрагентами = new Guid("094a40a7-ed99-9208-4505-57479cb0c8b9");//Прочие расчеты с контрагентами
		public static ВидыОперацийПланируемоеПоступлениеДС Получить(this ВидыОперацийПланируемоеПоступлениеДС Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОперацийПланируемоеПоступлениеДС Получить(this ВидыОперацийПланируемоеПоступлениеДС Значение, Guid Ссылка)
		{
			if(Ссылка == ОплатаПокупателя)
			{
				return ВидыОперацийПланируемоеПоступлениеДС.ОплатаПокупателя;
			}
			else if(Ссылка == ВозвратДенежныхСредствПоставщиком)
			{
				return ВидыОперацийПланируемоеПоступлениеДС.ВозвратДенежныхСредствПоставщиком;
			}
			else if(Ссылка == РасчетыПоКредитамИЗаймам)
			{
				return ВидыОперацийПланируемоеПоступлениеДС.РасчетыПоКредитамИЗаймам;
			}
			else if(Ссылка == ПриходДенежныхСредствРозничнаяВыручка)
			{
				return ВидыОперацийПланируемоеПоступлениеДС.ПриходДенежныхСредствРозничнаяВыручка;
			}
			else if(Ссылка == ПрочееПоступлениеДенежныхСредств)
			{
				return ВидыОперацийПланируемоеПоступлениеДС.ПрочееПоступлениеДенежныхСредств;
			}
			else if(Ссылка == ПрочиеРасчетыСКонтрагентами)
			{
				return ВидыОперацийПланируемоеПоступлениеДС.ПрочиеРасчетыСКонтрагентами;
			}
			return ВидыОперацийПланируемоеПоступлениеДС.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОперацийПланируемоеПоступлениеДС Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОперацийПланируемоеПоступлениеДС Значение)
		{
			switch (Значение)
			{
				case ВидыОперацийПланируемоеПоступлениеДС.ОплатаПокупателя: return ОплатаПокупателя;
				case ВидыОперацийПланируемоеПоступлениеДС.ВозвратДенежныхСредствПоставщиком: return ВозвратДенежныхСредствПоставщиком;
				case ВидыОперацийПланируемоеПоступлениеДС.РасчетыПоКредитамИЗаймам: return РасчетыПоКредитамИЗаймам;
				case ВидыОперацийПланируемоеПоступлениеДС.ПриходДенежныхСредствРозничнаяВыручка: return ПриходДенежныхСредствРозничнаяВыручка;
				case ВидыОперацийПланируемоеПоступлениеДС.ПрочееПоступлениеДенежныхСредств: return ПрочееПоступлениеДенежныхСредств;
				case ВидыОперацийПланируемоеПоступлениеДС.ПрочиеРасчетыСКонтрагентами: return ПрочиеРасчетыСКонтрагентами;
			}
			return Guid.Empty;
		}
	}
}