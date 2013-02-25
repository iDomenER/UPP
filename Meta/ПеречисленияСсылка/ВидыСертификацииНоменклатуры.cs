﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ВидыСертификацииНоменклатуры
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"d0154262-dad9-49f8-85fb-600a256b3f9e\", \"Представление\":\"ВнутренняяСертификация\"}")]
		ВнутренняяСертификация = 0,//Внутренняя сертификация
		[EnumMember(Value = "{\"Ссылка\":\"c667cc71-e325-4f70-ae1f-fe8f709ee017\", \"Представление\":\"ВнешняяСертификация\"}")]
		ВнешняяСертификация = 1,//Внешняя сертификация
	}
	public static partial class ВидыСертификацииНоменклатуры_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ВнутренняяСертификация = new Guid("0a60fb85-6b25-9e3f-49f8-dad9d0154262");//Внутренняя сертификация
		public static readonly Guid ВнешняяСертификация = new Guid("8ffe1fae-9e70-17e0-4f70-e325c667cc71");//Внешняя сертификация
		public static ВидыСертификацииНоменклатуры Получить(this ВидыСертификацииНоменклатуры Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыСертификацииНоменклатуры Получить(this ВидыСертификацииНоменклатуры Значение, Guid Ссылка)
		{
			if(Ссылка == ВнутренняяСертификация)
			{
				return ВидыСертификацииНоменклатуры.ВнутренняяСертификация;
			}
			else if(Ссылка == ВнешняяСертификация)
			{
				return ВидыСертификацииНоменклатуры.ВнешняяСертификация;
			}
			return ВидыСертификацииНоменклатуры.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыСертификацииНоменклатуры Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыСертификацииНоменклатуры Значение)
		{
			switch (Значение)
			{
				case ВидыСертификацииНоменклатуры.ВнутренняяСертификация: return ВнутренняяСертификация;
				case ВидыСертификацииНоменклатуры.ВнешняяСертификация: return ВнешняяСертификация;
			}
			return Guid.Empty;
		}
	}
}