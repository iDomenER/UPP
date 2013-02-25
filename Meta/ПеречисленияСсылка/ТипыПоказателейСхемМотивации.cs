﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Упр)
	///</summary>
	[DataContract]
	public enum ТипыПоказателейСхемМотивации
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"5887a7cc-4987-45b9-8e8c-6350a02b5748\", \"Представление\":\"Денежный\"}")]
		Денежный = 0,
		[EnumMember(Value = "{\"Ссылка\":\"56401879-c442-4bee-8b0a-dda7504e8f97\", \"Представление\":\"Числовой\"}")]
		Числовой = 1,
		[EnumMember(Value = "{\"Ссылка\":\"83dde191-0645-4236-95b1-4728bca25db1\", \"Представление\":\"Процентный\"}")]
		Процентный = 2,
		[EnumMember(Value = "{\"Ссылка\":\"aaced92f-777e-472b-aeee-291f3b146193\", \"Представление\":\"ОценочнаяШкалаЧисловая\"}")]
		ОценочнаяШкалаЧисловая = 3,//Оценочная шкала числовая
		[EnumMember(Value = "{\"Ссылка\":\"bfbba8f4-1a44-497f-81a6-4f32954b573f\", \"Представление\":\"ОценочнаяШкалаПроцентная\"}")]
		ОценочнаяШкалаПроцентная = 4,//Оценочная шкала процентная
		[EnumMember(Value = "{\"Ссылка\":\"aa260900-c93d-4efa-868f-5b7f598f8970\", \"Представление\":\"ТарифныйРазряд\"}")]
		ТарифныйРазряд = 5,//Тарифный разряд
		[EnumMember(Value = "{\"Ссылка\":\"75756a47-dfff-4b8b-8947-c22423455f22\", \"Представление\":\"СуммаПоказателя\"}")]
		СуммаПоказателя = 6,//Сумма показателя
		[EnumMember(Value = "{\"Ссылка\":\"92b6b717-598d-4647-98a4-b2be0a3a560a\", \"Представление\":\"Стаж\"}")]
		Стаж = 7,
	}
	public static partial class ТипыПоказателейСхемМотивации_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Денежный = new Guid("50638c8e-2ba0-4857-45b9-49875887a7cc");
		public static readonly Guid Числовой = new Guid("a7dd0a8b-4e50-978f-4bee-c44256401879");
		public static readonly Guid Процентный = new Guid("2847b195-a2bc-b15d-4236-064583dde191");
		public static readonly Guid ОценочнаяШкалаЧисловая = new Guid("1f29eeae-143b-9361-472b-777eaaced92f");//Оценочная шкала числовая
		public static readonly Guid ОценочнаяШкалаПроцентная = new Guid("324fa681-4b95-3f57-497f-1a44bfbba8f4");//Оценочная шкала процентная
		public static readonly Guid ТарифныйРазряд = new Guid("7f5b8f86-8f59-7089-4efa-c93daa260900");//Тарифный разряд
		public static readonly Guid СуммаПоказателя = new Guid("24c24789-4523-225f-4b8b-dfff75756a47");//Сумма показателя
		public static readonly Guid Стаж = new Guid("beb2a498-3a0a-0a56-4647-598d92b6b717");
		public static ТипыПоказателейСхемМотивации Получить(this ТипыПоказателейСхемМотивации Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ТипыПоказателейСхемМотивации Получить(this ТипыПоказателейСхемМотивации Значение, Guid Ссылка)
		{
			if(Ссылка == Денежный)
			{
				return ТипыПоказателейСхемМотивации.Денежный;
			}
			else if(Ссылка == Числовой)
			{
				return ТипыПоказателейСхемМотивации.Числовой;
			}
			else if(Ссылка == Процентный)
			{
				return ТипыПоказателейСхемМотивации.Процентный;
			}
			else if(Ссылка == ОценочнаяШкалаЧисловая)
			{
				return ТипыПоказателейСхемМотивации.ОценочнаяШкалаЧисловая;
			}
			else if(Ссылка == ОценочнаяШкалаПроцентная)
			{
				return ТипыПоказателейСхемМотивации.ОценочнаяШкалаПроцентная;
			}
			else if(Ссылка == ТарифныйРазряд)
			{
				return ТипыПоказателейСхемМотивации.ТарифныйРазряд;
			}
			else if(Ссылка == СуммаПоказателя)
			{
				return ТипыПоказателейСхемМотивации.СуммаПоказателя;
			}
			else if(Ссылка == Стаж)
			{
				return ТипыПоказателейСхемМотивации.Стаж;
			}
			return ТипыПоказателейСхемМотивации.ПустаяСсылка;
		}
		public static byte[] Ключ(this ТипыПоказателейСхемМотивации Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ТипыПоказателейСхемМотивации Значение)
		{
			switch (Значение)
			{
				case ТипыПоказателейСхемМотивации.Денежный: return Денежный;
				case ТипыПоказателейСхемМотивации.Числовой: return Числовой;
				case ТипыПоказателейСхемМотивации.Процентный: return Процентный;
				case ТипыПоказателейСхемМотивации.ОценочнаяШкалаЧисловая: return ОценочнаяШкалаЧисловая;
				case ТипыПоказателейСхемМотивации.ОценочнаяШкалаПроцентная: return ОценочнаяШкалаПроцентная;
				case ТипыПоказателейСхемМотивации.ТарифныйРазряд: return ТарифныйРазряд;
				case ТипыПоказателейСхемМотивации.СуммаПоказателя: return СуммаПоказателя;
				case ТипыПоказателейСхемМотивации.Стаж: return Стаж;
			}
			return Guid.Empty;
		}
	}
}