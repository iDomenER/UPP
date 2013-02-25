﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum СпособыВыгрузкиСебестоимостиВРозничнуюТорговлю
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"896d56a3-db65-4001-a583-a0e2bacd373b\", \"Представление\":\"НеВыгружать\"}")]
		НеВыгружать = 0,//Не выгружать
		[EnumMember(Value = "{\"Ссылка\":\"7539352f-b204-47bc-904d-3fa3fd702f7e\", \"Представление\":\"ВыгружатьСебестоимостьУпр\"}")]
		ВыгружатьСебестоимостьУпр = 1,//Выгружать себестоимость упр.
		[EnumMember(Value = "{\"Ссылка\":\"b2262095-0620-4353-8572-065633708470\", \"Представление\":\"ВыгружатьСебестоимостьРегл\"}")]
		ВыгружатьСебестоимостьРегл = 2,//Выгружать себестоимость регл.
	}
	public static partial class СпособыВыгрузкиСебестоимостиВРозничнуюТорговлю_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid НеВыгружать = new Guid("e2a083a5-cdba-3b37-4001-db65896d56a3");//Не выгружать
		public static readonly Guid ВыгружатьСебестоимостьУпр = new Guid("a33f4d90-70fd-7e2f-47bc-b2047539352f");//Выгружать себестоимость упр.
		public static readonly Guid ВыгружатьСебестоимостьРегл = new Guid("56067285-7033-7084-4353-0620b2262095");//Выгружать себестоимость регл.
		public static СпособыВыгрузкиСебестоимостиВРозничнуюТорговлю Получить(this СпособыВыгрузкиСебестоимостиВРозничнуюТорговлю Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СпособыВыгрузкиСебестоимостиВРозничнуюТорговлю Получить(this СпособыВыгрузкиСебестоимостиВРозничнуюТорговлю Значение, Guid Ссылка)
		{
			if(Ссылка == НеВыгружать)
			{
				return СпособыВыгрузкиСебестоимостиВРозничнуюТорговлю.НеВыгружать;
			}
			else if(Ссылка == ВыгружатьСебестоимостьУпр)
			{
				return СпособыВыгрузкиСебестоимостиВРозничнуюТорговлю.ВыгружатьСебестоимостьУпр;
			}
			else if(Ссылка == ВыгружатьСебестоимостьРегл)
			{
				return СпособыВыгрузкиСебестоимостиВРозничнуюТорговлю.ВыгружатьСебестоимостьРегл;
			}
			return СпособыВыгрузкиСебестоимостиВРозничнуюТорговлю.ПустаяСсылка;
		}
		public static byte[] Ключ(this СпособыВыгрузкиСебестоимостиВРозничнуюТорговлю Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СпособыВыгрузкиСебестоимостиВРозничнуюТорговлю Значение)
		{
			switch (Значение)
			{
				case СпособыВыгрузкиСебестоимостиВРозничнуюТорговлю.НеВыгружать: return НеВыгружать;
				case СпособыВыгрузкиСебестоимостиВРозничнуюТорговлю.ВыгружатьСебестоимостьУпр: return ВыгружатьСебестоимостьУпр;
				case СпособыВыгрузкиСебестоимостиВРозничнуюТорговлю.ВыгружатьСебестоимостьРегл: return ВыгружатьСебестоимостьРегл;
			}
			return Guid.Empty;
		}
	}
}