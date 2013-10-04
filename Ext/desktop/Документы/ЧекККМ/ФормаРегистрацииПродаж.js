﻿Ext.require(['Данные.Документы.ЧекККМ'], function () 
{
	Ext.define('Документы.ЧекККМ.ФормаРегистрацииПродаж',
	{
	extend: 'Ext.window.Window',
	id: 'ФормаРегистрацииПродаж',
	style: 'position:absolute;width:782px;height:450px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Чек ККМ',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		ПервоеОткрытие: true,
		items:
		[
		{
			xtype: 'label',
			id: 'СуммаДокумента',
			text: '1000000.00',
			style: 'position:absolute;left:458px;top:354px;width:311px;height:57px;text-align:right;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Правая', Номер: 109, Координата: 0},
					Левая: { Элемент: '', Граница: 'Левая', Номер: 109, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 109, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Нижняя', Номер: 109, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:57,
			Ширина:311,
			Верх:354,
			Лево:458,
		},
		{
			xtype: 'label',
			id: 'НадписьТекущийПользователь',
			text: 'НадписьТекущийПользователь',
			style: 'position:absolute;left:267px;top:5px;width:507px;height:15px;text-align:right;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:15,
			Ширина:507,
			Верх:5,
			Лево:267,
		},
		{
			xtype: 'label',
			id: 'ДисконтнаяКарта',
			text: 'ДисконтнаяКарта',
			style: 'position:absolute;left:160px;top:349px;width:129px;height:18px;text-align:left;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Правая', Номер: 108, Координата: 0},
					Левая: { Элемент: '', Граница: 'Левая', Номер: 108, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Верхняя', Номер: 108, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Нижняя', Номер: 108, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:18,
			Ширина:129,
			Верх:349,
			Лево:160,
		},
		{
			xtype: 'toolbar',
			id: ДействияФормы,
			style: 'position:absolute;left:0px;top:425px;width:782px;height:25px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 91, Координата: 0},
					Нижняя: { Элемент: 'ДействияФормы', Граница: 'Верхняя', Номер: 27, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:25,
			Ширина:782,
			Верх:425,
			Лево:0,
			width: 782,
			height: 25,
			items:
			[
				{
					xtype: 'tbfill'
				},
			]
		},
		{
			xtype: 'label',
			id: 'НадписьИтог',
			text: 'Итого:',
			style: 'position:absolute;left:300px;top:354px;width:152px;height:57px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Левая', Номер: 109, Координата: 0},
					Левая: { Элемент: '', Граница: 'Левая', Номер: 109, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 109, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Нижняя', Номер: 109, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:57,
			Ширина:152,
			Верх:354,
			Лево:300,
		},
		{
			xtype: 'label',
			id: 'Скидки',
			text: 'Скидки:',
			style: 'position:absolute;left:13px;top:395px;width:70px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Левая', Номер: 108, Координата: 0},
					Левая: { Элемент: '', Граница: 'Левая', Номер: 108, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:70,
			Верх:395,
			Лево:13,
		},
		{
			xtype: 'panel',
			id: ОсновнаяПанель,
			style: 'position:absolute;left:8px;top:5px;width:766px;height:336px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:336,
			Ширина:766,
			Верх:5,
			Лево:8,
			height: 336,width: 766,
			tabBar:{hidden:true},
			items:
			[
				{
					id: Товары,
					items:
					[
		{
			id: 'Товары',
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:15px;width:766px;height:252px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:252,
			Ширина:766,
			Верх:15,
			Лево:0,
			height: 252,width: 766,
			columns:
			[
				{
					text:'N',
					width:'28',
					dataIndex:'НомерСтроки',
					flex:1,
				},
				{
					text:'Код',
					width:'66',
					dataIndex:'Код',
					flex:1,
				},
				{
					text:'Артикул',
					width:'110',
					dataIndex:'Артикул',
					flex:1,
				},
				{
					text:'Штрихкод',
					width:'100',
					dataIndex:'ШтрихКод',
					flex:1,
				},
				{
					text:'Номенклатура',
					width:'299',
					dataIndex:'Номенклатура',
					flex:1,
				},
				{
					text:'Количество',
					width:'72',
					dataIndex:'Количество',
					flex:1,
				},
				{
					text:'Ед. изм.',
					width:'66',
					dataIndex:'ЕдиницаИзмерения',
					flex:1,
				},
				{
					text:'Цена',
					width:'85',
					dataIndex:'Цена',
					flex:1,
				},
				{
					text:'Сумма без скидок',
					width:'94',
					dataIndex:'СуммаБезСкидок',
					flex:1,
				},
				{
					text:'% Руч.ск.',
					width:'59',
					dataIndex:'ПроцентСкидкиНаценки',
					flex:1,
				},
				{
					text:'% Авт.ск.',
					width:'55',
					dataIndex:'ПроцентАвтоматическихСкидок',
					flex:1,
				},
				{
					text:'Сумма',
					width:'102',
					dataIndex:'Сумма',
					flex:1,
				},
				{
					text:'Характеристика номенклатуры',
					width:'122',
					dataIndex:'ХарактеристикаНоменклатуры',
					flex:1,
				},
				{
					text:'Серия номенклатуры',
					width:'123',
					dataIndex:'СерияНоменклатуры',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ЧекККМ/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'НомерСтроки',
					},
					{
						name:'Код',
					},
					{
						name:'Артикул',
					},
					{
						name:'ШтрихКод',
					},
					{
						name:'Номенклатура',
					},
					{
						name:'Количество',
					},
					{
						name:'ЕдиницаИзмерения',
					},
					{
						name:'Цена',
					},
					{
						name:'СуммаБезСкидок',
					},
					{
						name:'ПроцентСкидкиНаценки',
					},
					{
						name:'ПроцентАвтоматическихСкидок',
					},
					{
						name:'Сумма',
					},
					{
						name:'ХарактеристикаНоменклатуры',
					},
					{
						name:'СерияНоменклатуры',
					},
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('Товары');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.ЧекККМ.ФормаРегистрацииПродажСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ЧекККМ.ФормаРегистрацииПродажСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			xtype: 'fieldset',
			id: 'РамкаГруппы3',
			title: '',
			style: 'position:absolute;left:0px;top:271px;width:766px;height:65px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:65,
			Ширина:766,
			Верх:271,
			Лево:0,
		},
					]
				},
			]
		},
		{
			xtype: 'label',
			id: 'СкидкиИтогоСумма',
			text: 'СкидкиИтогоСумма',
			style: 'position:absolute;left:175px;top:395px;width:114px;height:19px;text-align:right;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Правая', Номер: 108, Координата: 0},
					Левая: { Элемент: '', Граница: 'Правая', Номер: 108, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Верхняя', Номер: 108, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Нижняя', Номер: 108, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:114,
			Верх:395,
			Лево:175,
		},
		{
			xtype: 'fieldset',
			id: 'РамкаГруппы1',
			title: '',
			style: 'position:absolute;left:8px;top:345px;width:284px;height:74px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:74,
			Ширина:284,
			Верх:345,
			Лево:8,
		},
		{
			xtype: 'fieldset',
			id: 'РамкаГруппы2',
			title: '',
			style: 'position:absolute;left:295px;top:345px;width:479px;height:74px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:74,
			Ширина:479,
			Верх:345,
			Лево:295,
		},
		{
			xtype: 'label',
			id: 'НадписьДисконтнаяКарта',
			text: 'Дисконтная карта:',
			style: 'position:absolute;left:13px;top:349px;width:142px;height:18px;text-align:left;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'НадписьДисконтнаяКарта', Граница: 'Левая', Номер: 112, Координата: 0},
					Левая: { Элемент: '', Граница: 'Левая', Номер: 108, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Верхняя', Номер: 108, Координата: 0},
					Нижняя: { Элемент: 'НадписьДисконтнаяКарта', Граница: 'Верхняя', Номер: 112, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:18,
			Ширина:142,
			Верх:349,
			Лево:13,
		},
		{
			xtype: 'label',
			id: 'ВладелецДисконтнойКарты',
			text: 'Владелец дисконтной карты',
			style: 'position:absolute;left:13px;top:371px;width:276px;height:18px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'ВладелецДисконтнойКарты', Граница: 'Левая', Номер: 115, Координата: 0},
					Левая: { Элемент: '', Граница: 'Левая', Номер: 108, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Верхняя', Номер: 108, Координата: 0},
					Нижняя: { Элемент: 'ВладелецДисконтнойКарты', Граница: 'Верхняя', Номер: 115, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:18,
			Ширина:276,
			Верх:371,
			Лево:13,
		},
		],
	}],
	dockedItems:
	[
	]
	});
	listeners:
	{
		resize:
		{
			fn: function (win, width, height, opt)
			{
				var форма = win.down('form');
				if (!форма.ПервоеОткрытие)
				{
					форма.items.each(function (item)
					{
					ПривязкаГраниц(item, item.ПозицияЭлемента);
					if (item.Групповой)
					{
						var элемент = Ext.getCmp(item.id).items.items[0].items.items;
						for (i = 0; i <= элемент.length -1; i += 1) 
						{
							var текЭлемент = элемент[i];
							ПривязкаГраниц(текЭлемент, текЭлемент.ПозицияЭлемента);
						}
					}
					});
				}
			}
		}
	}
});