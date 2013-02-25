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
	public enum ВидыОбъектовСобытия
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"f87b5cd9-5d02-4790-984a-879f9543b2bf\", \"Представление\":\"Контрагент\"}")]
		Контрагент = 0,
		[EnumMember(Value = "{\"Ссылка\":\"5b3356b0-3b17-4a36-9340-182f4b539e86\", \"Представление\":\"Кандидат\"}")]
		Кандидат = 1,
		[EnumMember(Value = "{\"Ссылка\":\"65bdc508-84cb-48e2-bb5a-ee4d550489bd\", \"Представление\":\"ПрочиеКонтактныеЛица\"}")]
		ПрочиеКонтактныеЛица = 2,//Прочие контактные лица
		[EnumMember(Value = "{\"Ссылка\":\"cb2dece5-3e9f-4f4d-9d39-bceb7591486e\", \"Представление\":\"ЗаявкаКандидата\"}")]
		ЗаявкаКандидата = 3,//Заявка кандидата
	}
	public static partial class ВидыОбъектовСобытия_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Контрагент = new Guid("9f874a98-4395-bfb2-4790-5d02f87b5cd9");
		public static readonly Guid Кандидат = new Guid("2f184093-534b-869e-4a36-3b175b3356b0");
		public static readonly Guid ПрочиеКонтактныеЛица = new Guid("4dee5abb-0455-bd89-48e2-84cb65bdc508");//Прочие контактные лица
		public static readonly Guid ЗаявкаКандидата = new Guid("ebbc399d-9175-6e48-4f4d-3e9fcb2dece5");//Заявка кандидата
		public static ВидыОбъектовСобытия Получить(this ВидыОбъектовСобытия Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОбъектовСобытия Получить(this ВидыОбъектовСобытия Значение, Guid Ссылка)
		{
			if(Ссылка == Контрагент)
			{
				return ВидыОбъектовСобытия.Контрагент;
			}
			else if(Ссылка == Кандидат)
			{
				return ВидыОбъектовСобытия.Кандидат;
			}
			else if(Ссылка == ПрочиеКонтактныеЛица)
			{
				return ВидыОбъектовСобытия.ПрочиеКонтактныеЛица;
			}
			else if(Ссылка == ЗаявкаКандидата)
			{
				return ВидыОбъектовСобытия.ЗаявкаКандидата;
			}
			return ВидыОбъектовСобытия.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОбъектовСобытия Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОбъектовСобытия Значение)
		{
			switch (Значение)
			{
				case ВидыОбъектовСобытия.Контрагент: return Контрагент;
				case ВидыОбъектовСобытия.Кандидат: return Кандидат;
				case ВидыОбъектовСобытия.ПрочиеКонтактныеЛица: return ПрочиеКонтактныеЛица;
				case ВидыОбъектовСобытия.ЗаявкаКандидата: return ЗаявкаКандидата;
			}
			return Guid.Empty;
		}
	}
}