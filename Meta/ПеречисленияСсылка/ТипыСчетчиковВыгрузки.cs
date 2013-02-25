﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ТипыСчетчиковВыгрузки
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"af6eb1d7-ea40-4fde-b353-8aa84729e69c\", \"Представление\":\"СчетчикДокументовВФормате201\"}")]
		СчетчикДокументовВФормате201 = 0,//Счетчик документов в формате 2.01
		[EnumMember(Value = "{\"Ссылка\":\"b19f344f-f659-4a65-9531-5335bf03c947\", \"Представление\":\"СчетчикДокументовВФормате300\"}")]
		СчетчикДокументовВФормате300 = 1,//Счетчик документов в формате 3.00
		[EnumMember(Value = "{\"Ссылка\":\"5efbf929-cdab-4745-a49f-073d7791cf89\", \"Представление\":\"СчетчикФайлов\"}")]
		СчетчикФайлов = 2,//Счетчик файлов
		[EnumMember(Value = "{\"Ссылка\":\"17cd9722-060b-46a6-939e-5defd1292710\", \"Представление\":\"СчетчикФайловАлко\"}")]
		СчетчикФайловАлко = 3,//Счетчик файлов для алкогольных деклараций
		[EnumMember(Value = "{\"Ссылка\":\"f85ad6c1-86e9-4cc7-ba08-5b94b7a6320e\", \"Представление\":\"СчетчикДокументовАлко\"}")]
		СчетчикДокументовАлко = 4,//Счетчик документов для алкогольных деклараций
	}
	public static partial class ТипыСчетчиковВыгрузки_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid СчетчикДокументовВФормате201 = new Guid("a88a53b3-2947-9ce6-4fde-ea40af6eb1d7");//Счетчик документов в формате 2.01
		public static readonly Guid СчетчикДокументовВФормате300 = new Guid("35533195-03bf-47c9-4a65-f659b19f344f");//Счетчик документов в формате 3.00
		public static readonly Guid СчетчикФайлов = new Guid("3d079fa4-9177-89cf-4745-cdab5efbf929");//Счетчик файлов
		public static readonly Guid СчетчикФайловАлко = new Guid("ef5d9e93-29d1-1027-46a6-060b17cd9722");//Счетчик файлов для алкогольных деклараций
		public static readonly Guid СчетчикДокументовАлко = new Guid("945b08ba-a6b7-0e32-4cc7-86e9f85ad6c1");//Счетчик документов для алкогольных деклараций
		public static ТипыСчетчиковВыгрузки Получить(this ТипыСчетчиковВыгрузки Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ТипыСчетчиковВыгрузки Получить(this ТипыСчетчиковВыгрузки Значение, Guid Ссылка)
		{
			if(Ссылка == СчетчикДокументовВФормате201)
			{
				return ТипыСчетчиковВыгрузки.СчетчикДокументовВФормате201;
			}
			else if(Ссылка == СчетчикДокументовВФормате300)
			{
				return ТипыСчетчиковВыгрузки.СчетчикДокументовВФормате300;
			}
			else if(Ссылка == СчетчикФайлов)
			{
				return ТипыСчетчиковВыгрузки.СчетчикФайлов;
			}
			else if(Ссылка == СчетчикФайловАлко)
			{
				return ТипыСчетчиковВыгрузки.СчетчикФайловАлко;
			}
			else if(Ссылка == СчетчикДокументовАлко)
			{
				return ТипыСчетчиковВыгрузки.СчетчикДокументовАлко;
			}
			return ТипыСчетчиковВыгрузки.ПустаяСсылка;
		}
		public static byte[] Ключ(this ТипыСчетчиковВыгрузки Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ТипыСчетчиковВыгрузки Значение)
		{
			switch (Значение)
			{
				case ТипыСчетчиковВыгрузки.СчетчикДокументовВФормате201: return СчетчикДокументовВФормате201;
				case ТипыСчетчиковВыгрузки.СчетчикДокументовВФормате300: return СчетчикДокументовВФормате300;
				case ТипыСчетчиковВыгрузки.СчетчикФайлов: return СчетчикФайлов;
				case ТипыСчетчиковВыгрузки.СчетчикФайловАлко: return СчетчикФайловАлко;
				case ТипыСчетчиковВыгрузки.СчетчикДокументовАлко: return СчетчикДокументовАлко;
			}
			return Guid.Empty;
		}
	}
}