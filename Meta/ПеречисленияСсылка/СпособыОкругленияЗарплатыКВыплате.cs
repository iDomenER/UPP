﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum СпособыОкругленияЗарплатыКВыплате
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"53b1bc1b-aaa3-4d6e-9777-7ee0b03299da\", \"Представление\":\"ПятьКоп\"}")]
		ПятьКоп = 0,//до пяти копеек
		[EnumMember(Value = "{\"Ссылка\":\"8ae37a2e-984f-4625-ad7b-c25635a4f9ac\", \"Представление\":\"ДесятьКоп\"}")]
		ДесятьКоп = 1,//до десяти копеек
		[EnumMember(Value = "{\"Ссылка\":\"1bcca02b-b27b-46f1-8ac7-be58ab2f0f90\", \"Представление\":\"ПятьдесятКоп\"}")]
		ПятьдесятКоп = 2,//до пятидесяти копеек
		[EnumMember(Value = "{\"Ссылка\":\"56e9515c-273e-4dc2-a03c-ba7be62347ab\", \"Представление\":\"Рубль\"}")]
		Рубль = 3,//до одного рубля
		[EnumMember(Value = "{\"Ссылка\":\"1d5b3ae0-ba18-4a6a-8189-8e2b7781b25c\", \"Представление\":\"ДваРубля\"}")]
		ДваРубля = 4,//до двух рублей
		[EnumMember(Value = "{\"Ссылка\":\"cb49b2d7-19a6-4d1a-a6a8-89d186a72b89\", \"Представление\":\"ПятьРублей\"}")]
		ПятьРублей = 5,//до пяти рублей
		[EnumMember(Value = "{\"Ссылка\":\"9ef0d93d-a411-473b-bda4-9b6735bdbd0c\", \"Представление\":\"ДесятьРублей\"}")]
		ДесятьРублей = 6,//до десяти рублей
		[EnumMember(Value = "{\"Ссылка\":\"9560cabc-3ae6-4ae1-a013-24df816e688a\", \"Представление\":\"ПятьдесятРублей\"}")]
		ПятьдесятРублей = 7,//до пятидесяти рублей
		[EnumMember(Value = "{\"Ссылка\":\"705d30a2-b16d-4f54-92a0-44f930698401\", \"Представление\":\"СтоРублей\"}")]
		СтоРублей = 8,//до ста рублей
		[EnumMember(Value = "{\"Ссылка\":\"0661f968-8299-42fa-948c-fe5df7aabd87\", \"Представление\":\"ПятьсотРублей\"}")]
		ПятьсотРублей = 9,//до пятисот рублей
		[EnumMember(Value = "{\"Ссылка\":\"c5ce5a1c-9afc-439a-8129-25e4c9ee63ea\", \"Представление\":\"Тысяча\"}")]
		Тысяча = 10,//до тысячи рублей
	}
	public static partial class СпособыОкругленияЗарплатыКВыплате_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПятьКоп = new Guid("e07e7797-32b0-da99-4d6e-aaa353b1bc1b");//до пяти копеек
		public static readonly Guid ДесятьКоп = new Guid("56c27bad-a435-acf9-4625-984f8ae37a2e");//до десяти копеек
		public static readonly Guid ПятьдесятКоп = new Guid("58bec78a-2fab-900f-46f1-b27b1bcca02b");//до пятидесяти копеек
		public static readonly Guid Рубль = new Guid("7bba3ca0-23e6-ab47-4dc2-273e56e9515c");//до одного рубля
		public static readonly Guid ДваРубля = new Guid("2b8e8981-8177-5cb2-4a6a-ba181d5b3ae0");//до двух рублей
		public static readonly Guid ПятьРублей = new Guid("d189a8a6-a786-892b-4d1a-19a6cb49b2d7");//до пяти рублей
		public static readonly Guid ДесятьРублей = new Guid("679ba4bd-bd35-0cbd-473b-a4119ef0d93d");//до десяти рублей
		public static readonly Guid ПятьдесятРублей = new Guid("df2413a0-6e81-8a68-4ae1-3ae69560cabc");//до пятидесяти рублей
		public static readonly Guid СтоРублей = new Guid("f944a092-6930-0184-4f54-b16d705d30a2");//до ста рублей
		public static readonly Guid ПятьсотРублей = new Guid("5dfe8c94-aaf7-87bd-42fa-82990661f968");//до пятисот рублей
		public static readonly Guid Тысяча = new Guid("e4252981-eec9-ea63-439a-9afcc5ce5a1c");//до тысячи рублей
		public static СпособыОкругленияЗарплатыКВыплате Получить(this СпособыОкругленияЗарплатыКВыплате Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СпособыОкругленияЗарплатыКВыплате Получить(this СпособыОкругленияЗарплатыКВыплате Значение, Guid Ссылка)
		{
			if(Ссылка == ПятьКоп)
			{
				return СпособыОкругленияЗарплатыКВыплате.ПятьКоп;
			}
			else if(Ссылка == ДесятьКоп)
			{
				return СпособыОкругленияЗарплатыКВыплате.ДесятьКоп;
			}
			else if(Ссылка == ПятьдесятКоп)
			{
				return СпособыОкругленияЗарплатыКВыплате.ПятьдесятКоп;
			}
			else if(Ссылка == Рубль)
			{
				return СпособыОкругленияЗарплатыКВыплате.Рубль;
			}
			else if(Ссылка == ДваРубля)
			{
				return СпособыОкругленияЗарплатыКВыплате.ДваРубля;
			}
			else if(Ссылка == ПятьРублей)
			{
				return СпособыОкругленияЗарплатыКВыплате.ПятьРублей;
			}
			else if(Ссылка == ДесятьРублей)
			{
				return СпособыОкругленияЗарплатыКВыплате.ДесятьРублей;
			}
			else if(Ссылка == ПятьдесятРублей)
			{
				return СпособыОкругленияЗарплатыКВыплате.ПятьдесятРублей;
			}
			else if(Ссылка == СтоРублей)
			{
				return СпособыОкругленияЗарплатыКВыплате.СтоРублей;
			}
			else if(Ссылка == ПятьсотРублей)
			{
				return СпособыОкругленияЗарплатыКВыплате.ПятьсотРублей;
			}
			else if(Ссылка == Тысяча)
			{
				return СпособыОкругленияЗарплатыКВыплате.Тысяча;
			}
			return СпособыОкругленияЗарплатыКВыплате.ПустаяСсылка;
		}
		public static byte[] Ключ(this СпособыОкругленияЗарплатыКВыплате Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СпособыОкругленияЗарплатыКВыплате Значение)
		{
			switch (Значение)
			{
				case СпособыОкругленияЗарплатыКВыплате.ПятьКоп: return ПятьКоп;
				case СпособыОкругленияЗарплатыКВыплате.ДесятьКоп: return ДесятьКоп;
				case СпособыОкругленияЗарплатыКВыплате.ПятьдесятКоп: return ПятьдесятКоп;
				case СпособыОкругленияЗарплатыКВыплате.Рубль: return Рубль;
				case СпособыОкругленияЗарплатыКВыплате.ДваРубля: return ДваРубля;
				case СпособыОкругленияЗарплатыКВыплате.ПятьРублей: return ПятьРублей;
				case СпособыОкругленияЗарплатыКВыплате.ДесятьРублей: return ДесятьРублей;
				case СпособыОкругленияЗарплатыКВыплате.ПятьдесятРублей: return ПятьдесятРублей;
				case СпособыОкругленияЗарплатыКВыплате.СтоРублей: return СтоРублей;
				case СпособыОкругленияЗарплатыКВыплате.ПятьсотРублей: return ПятьсотРублей;
				case СпособыОкругленияЗарплатыКВыплате.Тысяча: return Тысяча;
			}
			return Guid.Empty;
		}
	}
}