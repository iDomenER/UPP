﻿Ext.require(['Данные.Справочники.НастройкиРасчетаЦеныНоменклатуры'], function () 
{
	Ext.define('Справочники.НастройкиРасчетаЦеныНоменклатуры.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	id: 'ФормаСписка',
	style: 'position:absolute;width:793px;height:300px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Настройки расчета цены номенклатуры',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		ПервоеОткрытие: true,
		items:
		[
		{
			id: 'СправочникСписок',
			xtype: 'grid',
			style: 'position:absolute;left:174px;top:33px;width:611px;height:259px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Правая', Номер: 4, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
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
			Высота:259,
			Ширина:611,
			Верх:33,
			Лево:174,
			height: 259,width: 611,
			columns:
			[
				{
					text:'',
					width:'33',
					dataIndex:'Картинка',
					flex:1,
				},
				{
					text:'Наименование',
					width:'107',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Тип цен',
					width:'114',
					dataIndex:'ТипЦен.Представление',
					flex:1,
				},
				{
					text:'Новый док.',
					width:'80',
					dataIndex:'СоздаватьНовыйДокумент',
					flex:1,
				},
				{
					text:'Автоматич.',
					width:'74',
					dataIndex:'ФормироватьДокументыАвтоматически',
					flex:1,
				},
				{
					text:'Упр.',
					width:'32',
					dataIndex:'ОтражатьВУправленческомУчете',
					flex:1,
				},
				{
					text:'Регл.',
					width:'33',
					dataIndex:'ОтражатьВРегламентированномУчете',
					flex:1,
				},
				{
					text:'Комментарий',
					width:'100',
					dataIndex:'Комментарий',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.НастройкиРасчетаЦеныНоменклатуры").data,
					fields: ['Ссылка','Родитель.Представление','Картинка','Наименование','ТипЦен.Представление','СоздаватьНовыйДокумент','ФормироватьДокументыАвтоматически','ОтражатьВУправленческомУчете','ОтражатьВРегламентированномУчете','Комментарий',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/НастройкиРасчетаЦеныНоменклатуры/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Картинка',
					},
					{
						name:'Наименование',
					},
					{
						name:'ТипЦен',
					},
					{
						name:'СоздаватьНовыйДокумент',
					},
					{
						name:'ФормироватьДокументыАвтоматически',
					},
					{
						name:'ОтражатьВУправленческомУчете',
					},
					{
						name:'ОтражатьВРегламентированномУчете',
					},
					{
						name:'Комментарий',
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
						var грид = Ext.getCmp('СправочникСписок');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.НастройкиРасчетаЦеныНоменклатуры.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.НастройкиРасчетаЦеныНоменклатуры.ФормаСпискаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			id: ДействияФормы,
			style: 'position:absolute;left:0px;top:0px;width:793px;height:25px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ДействияФормы', Граница: 'Верхняя', Номер: 2, Координата: 0},
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
			Ширина:793,
			Верх:0,
			Лево:0,
			width: 793,
			height: 25,
			items:
			[
				{
					id:'',
					text:'',
					tooltip:'Добавить',
					iconCls:'x-copy',
				},
				{
					id:'',
					text:'',
					tooltip:'Новая группа',
					iconCls:'x-CreateFolder',
				},
				{
					id:'',
					text:'',
					tooltip:'Скопировать',
					iconCls:'x-copy',
				},
				{
					id:'',
					text:'',
					tooltip:'Изменить',
					iconCls:'x-Change',
				},
				{
					id:'',
					text:'',
					tooltip:'Установить пометку удаления',
					iconCls:'x-Delete',
				},
			]
		},
		{
			id: 'Дерево',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:160px;height:259px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Левая', Номер: 4, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
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
			Высота:259,
			Ширина:160,
			Верх:33,
			Лево:8,
			height: 259,width: 160,
			columns:
			[
				{
					text:'Наименование',
					width:'158',
					dataIndex:'Наименование',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.НастройкиРасчетаЦеныНоменклатуры").data,
					fields: ['Ссылка','Родитель.Представление','Наименование',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/НастройкиРасчетаЦеныНоменклатуры/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Наименование',
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
						var грид = Ext.getCmp('Дерево');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.НастройкиРасчетаЦеныНоменклатуры.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.НастройкиРасчетаЦеныНоменклатуры.ФормаСпискаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
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