﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Общ)
	///</summary>
	[DataContract]
	public enum ВидыОтчетности
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
	///<summary>
	///(Регл)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"ad89b07d-0a3d-40fa-b6b0-8ae46828be6a\", \"Представление\":\"РегламентированнаяОтчетность\"}")]
		РегламентированнаяОтчетность = 0,//Регламентированная отчетность
	///<summary>
	///(Упр)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"a1879de2-5909-44cc-8731-64919e6d57a7\", \"Представление\":\"ОтчетностьПоМСФО\"}")]
		ОтчетностьПоМСФО = 1,//Отчетность по МСФО
	}
	public static partial class ВидыОтчетности_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Регл)
		///</summary>
		public static readonly Guid РегламентированнаяОтчетность = new Guid("e48ab0b6-2868-6abe-40fa-0a3dad89b07d");//Регламентированная отчетность
		///<summary>
		///(Упр)
		///</summary>
		public static readonly Guid ОтчетностьПоМСФО = new Guid("91643187-6d9e-a757-44cc-5909a1879de2");//Отчетность по МСФО
		public static ВидыОтчетности Получить(this ВидыОтчетности Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОтчетности Получить(this ВидыОтчетности Значение, Guid Ссылка)
		{
			if(Ссылка == РегламентированнаяОтчетность)
			{
				return ВидыОтчетности.РегламентированнаяОтчетность;
			}
			else if(Ссылка == ОтчетностьПоМСФО)
			{
				return ВидыОтчетности.ОтчетностьПоМСФО;
			}
			return ВидыОтчетности.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОтчетности Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОтчетности Значение)
		{
			switch (Значение)
			{
				case ВидыОтчетности.РегламентированнаяОтчетность: return РегламентированнаяОтчетность;
				case ВидыОтчетности.ОтчетностьПоМСФО: return ОтчетностьПоМСФО;
			}
			return Guid.Empty;
		}
	}
}