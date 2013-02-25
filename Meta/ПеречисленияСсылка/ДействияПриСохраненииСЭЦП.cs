﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ДействияПриСохраненииСЭЦП
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"b347e774-2261-4f76-9bdb-3c6736983589\", \"Представление\":\"СохранятьВсеПодписи\"}")]
		СохранятьВсеПодписи = 0,//Сохранять все подписи
		[EnumMember(Value = "{\"Ссылка\":\"be7e2715-1243-49a8-8c7c-55d632d3cf6c\", \"Представление\":\"Спрашивать\"}")]
		Спрашивать = 1,
	}
	public static partial class ДействияПриСохраненииСЭЦП_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid СохранятьВсеПодписи = new Guid("673cdb9b-9836-8935-4f76-2261b347e774");//Сохранять все подписи
		public static readonly Guid Спрашивать = new Guid("d6557c8c-d332-6ccf-49a8-1243be7e2715");
		public static ДействияПриСохраненииСЭЦП Получить(this ДействияПриСохраненииСЭЦП Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ДействияПриСохраненииСЭЦП Получить(this ДействияПриСохраненииСЭЦП Значение, Guid Ссылка)
		{
			if(Ссылка == СохранятьВсеПодписи)
			{
				return ДействияПриСохраненииСЭЦП.СохранятьВсеПодписи;
			}
			else if(Ссылка == Спрашивать)
			{
				return ДействияПриСохраненииСЭЦП.Спрашивать;
			}
			return ДействияПриСохраненииСЭЦП.ПустаяСсылка;
		}
		public static byte[] Ключ(this ДействияПриСохраненииСЭЦП Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ДействияПриСохраненииСЭЦП Значение)
		{
			switch (Значение)
			{
				case ДействияПриСохраненииСЭЦП.СохранятьВсеПодписи: return СохранятьВсеПодписи;
				case ДействияПриСохраненииСЭЦП.Спрашивать: return Спрашивать;
			}
			return Guid.Empty;
		}
	}
}