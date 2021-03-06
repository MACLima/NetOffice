﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.MSFormsApi
{
    /// <summary>
    /// IMdcCombo
    /// </summary>
    [SyntaxBypass]
    public interface IMdcCombo_ : ICOMObject
    {
        #region Properties

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        /// <param name="pvargColumn">optional object pvargColumn</param>
        /// <param name="pvargIndex">optional object pvargIndex</param>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        object get_Column(object pvargColumn, object pvargIndex);

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        /// <param name="pvargColumn">optional object pvargColumn</param>
        /// <param name="pvargIndex">optional object pvargIndex</param>
        /// <param name="value">optional object value</param>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        void set_Column(object pvargColumn, object pvargIndex, object value);

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Alias for get_Column
        /// </summary>
        /// <param name="pvargColumn">optional object pvargColumn</param>
        /// <param name="pvargIndex">optional object pvargIndex</param>
        [SupportByVersion("MSForms", 2), Redirect("get_Column")]
        object Column(object pvargColumn, object pvargIndex);

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        /// <param name="pvargColumn">optional object pvargColumn</param>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        object get_Column(object pvargColumn);

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        /// <param name="pvargColumn">optional object pvargColumn</param>
        /// <param name="value">optional object value</param>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        void set_Column(object pvargColumn, object value);

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Alias for get_Column
        /// </summary>
        /// <param name="pvargColumn">optional object pvargColumn</param>
        [SupportByVersion("MSForms", 2), Redirect("get_Column")]
        object Column(object pvargColumn);

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        /// <param name="pvargIndex">optional object pvargIndex</param>
        /// <param name="pvargColumn">optional object pvargColumn</param>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        object get_List(object pvargIndex, object pvargColumn);

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        /// <param name="pvargIndex">optional object pvargIndex</param>
        /// <param name="pvargColumn">optional object pvargColumn</param>
        /// <param name="value">optional object value</param>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        void set_List(object pvargIndex, object pvargColumn, object value);

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Alias for get_List
        /// </summary>
        /// <param name="pvargIndex">optional object pvargIndex</param>
        /// <param name="pvargColumn">optional object pvargColumn</param>
        [SupportByVersion("MSForms", 2), Redirect("get_List")]
        object List(object pvargIndex, object pvargColumn);

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        /// <param name="pvargIndex">optional object pvargIndex</param>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        object get_List(object pvargIndex);

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        /// <param name="pvargIndex">optional object pvargIndex</param>
        /// <param name="value">optional object value</param>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        void set_List(object pvargIndex, object value);

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Alias for get_List
        /// </summary>
        /// <param name="pvargIndex">optional object pvargIndex</param>
        [SupportByVersion("MSForms", 2), Redirect("get_List")]
        object List(object pvargIndex);

        #endregion
    }

    /// <summary>
    /// DispatchInterface IMdcCombo 
    /// SupportByVersion MSForms, 2
    /// </summary>
    [SupportByVersion("MSForms", 2)]
    [EntityType(EntityType.IsDispatchInterface), BaseType]
	[TypeId("8BD21D33-EC42-11CE-9E0D-00AA006002F3")]
    [CoClassSource(typeof(NetOffice.MSFormsApi.ComboBox))]
    public interface IMdcCombo : IMdcCombo_
    {
        #region Properties

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        bool AutoSize { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        bool AutoTab { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        bool AutoWordSelect { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        Int32 BackColor { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        NetOffice.MSFormsApi.Enums.fmBackStyle BackStyle { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        Int32 BorderColor { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        NetOffice.MSFormsApi.Enums.fmBorderStyle BorderStyle { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        bool BordersSuppress { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        object BoundColumn { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        bool CanPaste { get; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        Int32 ColumnCount { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        bool ColumnHeads { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        string ColumnWidths { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        Int32 CurTargetX { get; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        Int32 CurTargetY { get; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        Int32 CurX { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        NetOffice.MSFormsApi.Enums.fmDropButtonStyle DropButtonStyle { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        bool Enabled { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [BaseResult]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        NetOffice.MSFormsApi.Font _Font_Reserved { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [BaseResult]
        NetOffice.MSFormsApi.Font Font { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        bool FontBold { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        bool FontItalic { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        string FontName { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        float FontSize { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        bool FontStrikethru { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        bool FontUnderline { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        Int16 FontWeight { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        Int32 ForeColor { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        bool HideSelection { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        Int32 LineCount { get; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        Int32 ListCount { get; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("MSForms", 2), ProxyResult]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        object ListCursor { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        object ListIndex { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        Int32 ListRows { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        NetOffice.MSFormsApi.Enums.fmListStyle ListStyle { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        object ListWidth { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        bool Locked { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        NetOffice.MSFormsApi.Enums.fmMatchEntry MatchEntry { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        bool MatchFound { get; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        bool MatchRequired { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        Int32 MaxLength { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2), NativeResult]
        stdole.Picture MouseIcon { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        NetOffice.MSFormsApi.Enums.fmMousePointer MousePointer { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        bool SelectionMargin { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        Int32 SelLength { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        Int32 SelStart { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        string SelText { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        NetOffice.MSFormsApi.Enums.fmShowDropButtonWhen ShowDropButtonWhen { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        NetOffice.MSFormsApi.Enums.fmSpecialEffect SpecialEffect { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        NetOffice.MSFormsApi.Enums.fmStyle Style { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        string Text { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        NetOffice.MSFormsApi.Enums.fmTextAlign TextAlign { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        object TextColumn { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        Int32 TextLength { get; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        object TopIndex { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        bool Valid { get; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        object Value { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        new object Column { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        new object List { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        NetOffice.MSFormsApi.Enums.fmIMEMode IMEMode { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        NetOffice.MSFormsApi.Enums.fmEnterFieldBehavior EnterFieldBehavior { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get/Set
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        NetOffice.MSFormsApi.Enums.fmDragBehavior DragBehavior { get; set; }

        /// <summary>
        /// SupportByVersion MSForms 2
        /// Get
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        NetOffice.MSFormsApi.Enums.fmDisplayStyle DisplayStyle { get; }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion MSForms 2
        /// </summary>
        /// <param name="pvargItem">optional object pvargItem</param>
        /// <param name="pvargIndex">optional object pvargIndex</param>
        [SupportByVersion("MSForms", 2)]
        void AddItem(object pvargItem, object pvargIndex);

        /// <summary>
        /// SupportByVersion MSForms 2
        /// </summary>
        [CustomMethod]
        [SupportByVersion("MSForms", 2)]
        void AddItem();

        /// <summary>
        /// SupportByVersion MSForms 2
        /// </summary>
        /// <param name="pvargItem">optional object pvargItem</param>
        [CustomMethod]
        [SupportByVersion("MSForms", 2)]
        void AddItem(object pvargItem);

        /// <summary>
        /// SupportByVersion MSForms 2
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        void Clear();

        /// <summary>
        /// SupportByVersion MSForms 2
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        void DropDown();

        /// <summary>
        /// SupportByVersion MSForms 2
        /// </summary>
        /// <param name="pvargIndex">object pvargIndex</param>
        [SupportByVersion("MSForms", 2)]
        void RemoveItem(object pvargIndex);

        /// <summary>
        /// SupportByVersion MSForms 2
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        void Copy();

        /// <summary>
        /// SupportByVersion MSForms 2
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        void Cut();

        /// <summary>
        /// SupportByVersion MSForms 2
        /// </summary>
        [SupportByVersion("MSForms", 2)]
        void Paste();

        #endregion
    }
}
