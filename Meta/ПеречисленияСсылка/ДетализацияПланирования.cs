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
	public enum ДетализацияПланирования
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"304fa183-1b64-4427-94bd-7a731a09c9a2\", \"Представление\":\"Номенклатура\"}")]
		Номенклатура = 0,
		[EnumMember(Value = "{\"Ссылка\":\"28fa6cb3-ca6f-42b2-abef-1292aa227a1a\", \"Представление\":\"НоменклатурныеГруппы\"}")]
		НоменклатурныеГруппы = 1,//Номенклатурные группы
	}
	public static partial class ДетализацияПланирования_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Номенклатура = new Guid("737abd94-091a-a2c9-4427-1b64304fa183");
		public static readonly Guid НоменклатурныеГруппы = new Guid("9212efab-22aa-1a7a-42b2-ca6f28fa6cb3");//Номенклатурные группы
		public static ДетализацияПланирования Получить(this ДетализацияПланирования Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ДетализацияПланирования Получить(this ДетализацияПланирования Значение, Guid Ссылка)
		{
			if(Ссылка == Номенклатура)
			{
				return ДетализацияПланирования.Номенклатура;
			}
			else if(Ссылка == НоменклатурныеГруппы)
			{
				return ДетализацияПланирования.НоменклатурныеГруппы;
			}
			return ДетализацияПланирования.ПустаяСсылка;
		}
		public static byte[] Ключ(this ДетализацияПланирования Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ДетализацияПланирования Значение)
		{
			switch (Значение)
			{
				case ДетализацияПланирования.Номенклатура: return Номенклатура;
				case ДетализацияПланирования.НоменклатурныеГруппы: return НоменклатурныеГруппы;
			}
			return Guid.Empty;
		}
	}
}