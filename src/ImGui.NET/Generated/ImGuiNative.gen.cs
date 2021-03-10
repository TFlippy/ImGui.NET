using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    public static unsafe partial class ImGuiNative
    {
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* igAcceptDragDropPayload(byte* type, ImGuiDragDropFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igActivateItem(uint id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igAddContextHook(ImGuiContext* context, ImGuiContextHook* hook);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igAlignTextToFramePadding();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igArrowButton(byte* str_id, ImGuiDir dir);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igArrowButtonEx(byte* str_id, ImGuiDir dir, Vector2 size_arg, ImGuiButtonFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBegin(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChildStr(byte* str_id, Vector2 size, byte border, ImGuiWindowFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChildID(uint id, Vector2 size, byte border, ImGuiWindowFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChildEx(byte* name, uint id, Vector2 size_arg, byte border, ImGuiWindowFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChildFrame(uint id, Vector2 size, ImGuiWindowFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginColumns(byte* str_id, int count, ImGuiOldColumnFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginCombo(byte* label, byte* preview_value, ImGuiComboFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginDragDropSource(ImGuiDragDropFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginDragDropTarget();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginDragDropTargetCustom(ImRect bb, uint id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginGroup();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginListBox(byte* label, Vector2 size);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginMainMenuBar();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginMenu(byte* label, byte enabled);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginMenuBar();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopup(byte* str_id, ImGuiWindowFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupContextItem(byte* str_id, ImGuiPopupFlags popup_flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupContextVoid(byte* str_id, ImGuiPopupFlags popup_flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupContextWindow(byte* str_id, ImGuiPopupFlags popup_flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupEx(uint id, ImGuiWindowFlags extra_flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupModal(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTabBar(byte* str_id, ImGuiTabBarFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTabBarEx(ImGuiTabBar* tab_bar, ImRect bb, ImGuiTabBarFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTabItem(byte* label, byte* p_open, ImGuiTabItemFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTable(byte* str_id, int column, ImGuiTableFlags flags, Vector2 outer_size, float inner_width);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTableEx(byte* name, uint id, int columns_count, ImGuiTableFlags flags, Vector2 outer_size, float inner_width);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginTooltip();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginTooltipEx(ImGuiWindowFlags extra_flags, ImGuiTooltipFlags tooltip_flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBringWindowToDisplayBack(ImGuiWindow* window);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBringWindowToDisplayFront(ImGuiWindow* window);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBringWindowToFocusFront(ImGuiWindow* window);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBullet();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBulletText(byte* fmt);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igButton(byte* label, Vector2 size);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igButtonBehavior(ImRect bb, uint id, byte* out_hovered, byte* out_held, ImGuiButtonFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igButtonEx(byte* label, Vector2 size_arg, ImGuiButtonFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcItemSize(Vector2* pOut, Vector2 size, float default_w, float default_h);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igCalcItemWidth();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcListClipping(int items_count, float items_height, int* out_items_display_start, int* out_items_display_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcTextSize(Vector2* pOut, byte* text, byte* text_end, byte hide_text_after_double_hash, float wrap_width);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igCalcTypematicRepeatAmount(float t0, float t1, float repeat_delay, float repeat_rate);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcWindowNextAutoFitSize(Vector2* pOut, ImGuiWindow* window);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igCalcWrapWidthForPos(Vector2 pos, float wrap_pos_x);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCallContextHooks(ImGuiContext* context, ImGuiContextHookType type);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCaptureKeyboardFromApp(byte want_capture_keyboard_value);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCaptureMouseFromApp(byte want_capture_mouse_value);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckbox(byte* label, byte* v);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckboxFlagsIntPtr(byte* label, int* flags, int flags_value);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckboxFlagsUintPtr(byte* label, uint* flags, uint flags_value);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckboxFlagsS64Ptr(byte* label, long* flags, long flags_value);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckboxFlagsU64Ptr(byte* label, ulong* flags, ulong flags_value);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClearActiveID();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClearDragDrop();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClearIniSettings();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCloseButton(uint id, Vector2 pos);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCloseCurrentPopup();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClosePopupsOverWindow(ImGuiWindow* ref_window, byte restore_focus_to_window_under_popup);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClosePopupToLevel(int remaining, byte restore_focus_to_window_under_popup);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCollapseButton(uint id, Vector2 pos);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCollapsingHeaderTreeNodeFlags(byte* label, ImGuiTreeNodeFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCollapsingHeaderBoolPtr(byte* label, byte* p_visible, ImGuiTreeNodeFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorButton(byte* desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igColorConvertFloat4ToU32(Vector4 @in);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorConvertU32ToFloat4(Vector4* pOut, uint @in);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorEdit3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorEdit4(byte* label, Vector4* col, ImGuiColorEditFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorEditOptionsPopup(float* col, ImGuiColorEditFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorPicker3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorPicker4(byte* label, Vector4* col, ImGuiColorEditFlags flags, float* ref_col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorPickerOptionsPopup(float* ref_col, ImGuiColorEditFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorTooltip(byte* text, float* col, ImGuiColorEditFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColumns(int count, byte* id, byte border);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igComboStr_arr(byte* label, int* current_item, byte** items, int items_count, int popup_max_height_in_items);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igComboStr(byte* label, int* current_item, byte* items_separated_by_zeros, int popup_max_height_in_items);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiContext* igCreateContext(ImFontAtlas* shared_font_atlas);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* igCreateNewWindowSettings(byte* name);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDataTypeApplyOp(ImGuiDataType data_type, int op, void* output, void* arg_1, void* arg_2);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDataTypeApplyOpFromText(byte* buf, byte* initial_value_buf, ImGuiDataType data_type, void* p_data, byte* format);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDataTypeClamp(ImGuiDataType data_type, void* p_data, void* p_min, void* p_max);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igDataTypeCompare(ImGuiDataType data_type, void* arg_1, void* arg_2);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igDataTypeFormatString(byte* buf, int buf_size, ImGuiDataType data_type, void* p_data, byte* format);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDataTypeInfo* igDataTypeGetInfo(ImGuiDataType data_type);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDebugCheckVersionAndDataLayout(byte* version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugDrawItemRect(uint col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeColumns(ImGuiOldColumns* columns);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeDrawCmdShowMeshAndBoundingBox(ImDrawList* out_draw_list, ImDrawList* draw_list, ImDrawCmd* draw_cmd, byte show_mesh, byte show_aabb);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeDrawList(ImGuiWindow* window, ImDrawList* draw_list, byte* label);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeStorage(ImGuiStorage* storage, byte* label);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeTabBar(ImGuiTabBar* tab_bar, byte* label);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeTable(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeTableSettings(ImGuiTableSettings* settings);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeViewport(ImGuiViewportP* viewport);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeWindow(ImGuiWindow* window, byte* label);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeWindowSettings(ImGuiWindowSettings* settings);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeWindowsList(ImVector* windows, byte* label);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugRenderViewportThumbnail(ImDrawList* draw_list, ImGuiViewportP* viewport, ImRect bb);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugStartItemPicker();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDestroyContext(ImGuiContext* ctx);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragBehavior(uint id, ImGuiDataType data_type, void* p_v, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat2(byte* label, Vector2* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat3(byte* label, Vector3* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat4(byte* label, Vector4* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloatRange2(byte* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt2(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt3(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt4(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragIntRange2(byte* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragScalar(byte* label, ImGuiDataType data_type, void* p_data, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDummy(Vector2 size);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEnd();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndChild();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndChildFrame();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndColumns();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndCombo();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndDragDropSource();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndDragDropTarget();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndFrame();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndGroup();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndListBox();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndMainMenuBar();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndMenu();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndMenuBar();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndPopup();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTabBar();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTabItem();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTable();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTooltip();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igErrorCheckEndFrameRecover(void* log_callback, void* user_data);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFindBestWindowPosForPopup(Vector2* pOut, ImGuiWindow* window);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFindBestWindowPosForPopupEx(Vector2* pOut, Vector2 ref_pos, Vector2 size, ImGuiDir* last_dir, ImRect r_outer, ImRect r_avoid, ImGuiPopupPositionPolicy policy);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiOldColumns* igFindOrCreateColumns(ImGuiWindow* window, uint id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* igFindOrCreateWindowSettings(byte* name);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igFindRenderedTextEnd(byte* text, byte* text_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiSettingsHandler* igFindSettingsHandler(byte* type_name);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igFindWindowByID(uint id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igFindWindowByName(byte* name);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* igFindWindowSettings(uint id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igFocusableItemRegister(ImGuiWindow* window, uint id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFocusableItemUnregister(ImGuiWindow* window);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFocusTopMostWindowUnderOne(ImGuiWindow* under_this_window, ImGuiWindow* ignore_window);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFocusWindow(ImGuiWindow* window);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGcAwakeTransientWindowBuffers(ImGuiWindow* window);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGcCompactTransientMiscBuffers();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGcCompactTransientWindowBuffers(ImGuiWindow* window);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetActiveID();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetBackgroundDrawListNil();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetBackgroundDrawListViewportPtr(ImGuiViewport* viewport);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetClipboardText();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColorU32Col(ImGuiCol idx, float alpha_mul);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColorU32Vec4(Vector4 col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColorU32U32(uint col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetColumnIndex();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnNormFromOffset(ImGuiOldColumns* columns, float offset);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnOffset(int column_index);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnOffsetFromNorm(ImGuiOldColumns* columns, float offset_norm);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetColumnsCount();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColumnsID(byte* str_id, int count);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnWidth(int column_index);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetContentRegionAvail(Vector2* pOut);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetContentRegionMax(Vector2* pOut);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetContentRegionMaxAbs(Vector2* pOut);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiContext* igGetCurrentContext();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igGetCurrentWindow();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igGetCurrentWindowRead();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetCursorPos(Vector2* pOut);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetCursorPosX();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetCursorPosY();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetCursorScreenPos(Vector2* pOut);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetCursorStartPos(Vector2* pOut);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* igGetDefaultFont();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* igGetDragDropPayload();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawData* igGetDrawData();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igGetDrawListSharedData();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetFocusedFocusScope();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetFocusID();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetFocusScope();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* igGetFont();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetFontSize();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetFontTexUvWhitePixel(Vector2* pOut);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetForegroundDrawListNil();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetForegroundDrawListWindowPtr(ImGuiWindow* window);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetForegroundDrawListViewportPtr(ImGuiViewport* viewport);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetFrameCount();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetFrameHeight();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetFrameHeightWithSpacing();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetHoveredID();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetIDStr(byte* str_id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetIDStrStr(byte* str_id_begin, byte* str_id_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetIDPtr(void* ptr_id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetIDWithSeed(byte* str_id_begin, byte* str_id_end, uint seed);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiInputTextState* igGetInputTextState(uint id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiIO* igGetIO();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetItemID();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetItemRectMax(Vector2* pOut);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetItemRectMin(Vector2* pOut);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetItemRectSize(Vector2* pOut);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiItemFlags igGetItemsFlags();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiItemStatusFlags igGetItemStatusFlags();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetKeyIndex(ImGuiKey imgui_key);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetKeyPressedAmount(int key_index, float repeat_delay, float rate);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* igGetMainViewport();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKeyModFlags igGetMergedKeyModFlags();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiMouseCursor igGetMouseCursor();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetMouseDragDelta(Vector2* pOut, ImGuiMouseButton button, float lock_threshold);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetMousePos(Vector2* pOut);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetMousePosOnOpeningCurrentPopup(Vector2* pOut);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetNavInputAmount(ImGuiNavInput n, ImGuiInputReadMode mode);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetNavInputAmount2d(Vector2* pOut, ImGuiNavDirSourceFlags dir_sources, ImGuiInputReadMode mode, float slow_factor, float fast_factor);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollMaxX();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollMaxY();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollX();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollY();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStorage* igGetStateStorage();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle* igGetStyle();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetStyleColorName(ImGuiCol idx);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* igGetStyleColorVec4(ImGuiCol idx);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetTextLineHeight();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetTextLineHeightWithSpacing();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igGetTime();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igGetTopMostPopupModal();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetTreeNodeToLabelSpacing();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetVersion();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowAllowedExtentRect(ImRect* pOut, ImGuiWindow* window);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowContentRegionMax(Vector2* pOut);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowContentRegionMin(Vector2* pOut);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetWindowContentRegionWidth();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetWindowDrawList();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetWindowHeight();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowPos(Vector2* pOut);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetWindowResizeID(ImGuiWindow* window, int n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetWindowScrollbarID(ImGuiWindow* window, ImGuiAxis axis);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowScrollbarRect(ImRect* pOut, ImGuiWindow* window, ImGuiAxis axis);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowSize(Vector2* pOut);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetWindowWidth();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImAbsFloat(float x);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImAbsdouble(double x);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImage(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 tint_col, Vector4 border_col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImageButton(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, int frame_padding, Vector4 bg_col, Vector4 tint_col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImageButtonEx(uint id, IntPtr texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector2 padding, Vector4 bg_col, Vector4 tint_col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImAlphaBlendColors(uint col_a, uint col_b);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierCubicCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierCubicClosestPoint(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, int num_segments);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierCubicClosestPointCasteljau(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, float tess_tol);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierQuadraticCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, float t);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBitArrayClearBit(uint* arr, int n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBitArraySetBit(uint* arr, int n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBitArraySetBitRange(uint* arr, int n, int n2);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImBitArrayTestBit(uint* arr, int n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImCharIsBlankA(byte c);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImCharIsBlankW(uint c);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImClamp(Vector2* pOut, Vector2 v, Vector2 mn, Vector2 mx);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImDot(Vector2 a, Vector2 b);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImFileClose(IntPtr file);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong igImFileGetSize(IntPtr file);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* igImFileLoadToMemory(byte* filename, byte* mode, uint* out_file_size, int padding_bytes);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igImFileOpen(byte* filename, byte* mode);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong igImFileRead(void* data, ulong size, ulong count, IntPtr file);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong igImFileWrite(void* data, ulong size, ulong count, IntPtr file);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImFloorFloat(float f);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFloorVec2(Vector2* pOut, Vector2 v);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildFinish(ImFontAtlas* atlas);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildInit(ImFontAtlas* atlas);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildMultiplyCalcLookupTable(byte* out_table, float in_multiply_factor);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildMultiplyRectAlpha8(byte* table, byte* pixels, int x, int y, int w, int h, int stride);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildPackCustomRects(ImFontAtlas* atlas, void* stbrp_context_opaque);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildRender32bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char, uint in_marker_pixel_value);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildRender8bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char, byte in_marker_pixel_value);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildSetupFont(ImFontAtlas* atlas, ImFont* font, ImFontConfig* font_config, float ascent, float descent);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontBuilderIO* igImFontAtlasGetBuilderForStbTruetype();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImFormatString(byte* buf, uint buf_size, byte* fmt);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDir igImGetDirQuadrantFromDelta(float dx, float dy);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImHashData(void* data, uint data_size, uint seed);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImHashStr(byte* data, uint data_size, uint seed);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImInvLength(Vector2 lhs, float fail_value);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImIsPowerOfTwoInt(int v);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImIsPowerOfTwoU64(ulong v);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLengthSqrVec2(Vector2 lhs);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLengthSqrVec4(Vector4 lhs);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLerpVec2Float(Vector2* pOut, Vector2 a, Vector2 b, float t);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLerpVec2Vec2(Vector2* pOut, Vector2 a, Vector2 b, Vector2 t);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLerpVec4(Vector4* pOut, Vector4 a, Vector4 b, float t);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLinearSweep(float current, float target, float speed);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLineClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 p);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLogFloat(float x);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImLogdouble(double x);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImMax(Vector2* pOut, Vector2 lhs, Vector2 rhs);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImMin(Vector2* pOut, Vector2 lhs, Vector2 rhs);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImModPositive(int a, int b);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImMul(Vector2* pOut, Vector2 lhs, Vector2 rhs);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImParseFormatFindEnd(byte* format);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImParseFormatFindStart(byte* format);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImParseFormatPrecision(byte* format, int default_value);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImParseFormatTrimDecorations(byte* format, byte* buf, uint buf_size);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImPowFloat(float x, float y);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImPowdouble(double x, double y);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImRotate(Vector2* pOut, Vector2 v, float cos_a, float sin_a);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImSaturate(float f);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImSignFloat(float x);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImSigndouble(double x);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* igImStrbolW(ushort* buf_mid_line, ushort* buf_begin);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrchrRange(byte* str_begin, byte* str_end, byte c);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrdup(byte* str);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrdupcpy(byte* dst, uint* p_dst_size, byte* str);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStreolRange(byte* str, byte* str_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImStricmp(byte* str1, byte* str2);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStristr(byte* haystack, byte* haystack_end, byte* needle, byte* needle_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImStrlenW(ushort* str);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImStrncpy(byte* dst, byte* src, uint count);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImStrnicmp(byte* str1, byte* str2, uint count);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrSkipBlank(byte* str);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImStrTrimBlanks(byte* str);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCharFromUtf8(uint* out_char, byte* in_text, byte* in_text_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCountCharsFromUtf8(byte* in_text, byte* in_text_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCountUtf8BytesFromChar(byte* in_text, byte* in_text_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCountUtf8BytesFromStr(ushort* in_text, ushort* in_text_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextStrFromUtf8(ushort* buf, int buf_size, byte* in_text, byte* in_text_end, byte** in_remaining);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextStrToUtf8(byte* buf, int buf_size, ushort* in_text, ushort* in_text_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImTriangleArea(Vector2 a, Vector2 b, Vector2 c);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImTriangleBarycentricCoords(Vector2 a, Vector2 b, Vector2 c, Vector2 p, float* out_u, float* out_v, float* out_w);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImTriangleClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 c, Vector2 p);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImTriangleContainsPoint(Vector2 a, Vector2 b, Vector2 c, Vector2 p);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImUpperPowerOfTwo(int v);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igIndent(float indent_w);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igInitialize(ImGuiContext* context);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputDouble(byte* label, double* v, double step, double step_fast, byte* format, ImGuiInputTextFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat(byte* label, float* v, float step, float step_fast, byte* format, ImGuiInputTextFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat2(byte* label, Vector2* v, byte* format, ImGuiInputTextFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat3(byte* label, Vector3* v, byte* format, ImGuiInputTextFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat4(byte* label, Vector4* v, byte* format, ImGuiInputTextFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt(byte* label, int* v, int step, int step_fast, ImGuiInputTextFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt2(byte* label, int* v, ImGuiInputTextFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt3(byte* label, int* v, ImGuiInputTextFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt4(byte* label, int* v, ImGuiInputTextFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputText(byte* label, byte* buf, uint buf_size, ImGuiInputTextFlags flags, delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> callback, void* user_data);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputTextEx(byte* label, byte* hint, byte* buf, int buf_size, Vector2 size_arg, ImGuiInputTextFlags flags, delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> callback, void* user_data);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputTextMultiline(byte* label, byte* buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> callback, void* user_data);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputTextWithHint(byte* label, byte* hint, byte* buf, uint buf_size, ImGuiInputTextFlags flags, delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> callback, void* user_data);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInvisibleButton(byte* str_id, Vector2 size, ImGuiButtonFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsActiveIdUsingKey(ImGuiKey key);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsActiveIdUsingNavDir(ImGuiDir dir);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsActiveIdUsingNavInput(ImGuiNavInput input);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyItemActive();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyItemFocused();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyItemHovered();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyMouseDown();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsClippedEx(ImRect bb, uint id, byte clip_even_when_logged);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsDragDropPayloadBeingAccepted();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemActivated();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemActive();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemClicked(ImGuiMouseButton mouse_button);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemDeactivated();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemDeactivatedAfterEdit();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemEdited();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemFocused();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemHovered(ImGuiHoveredFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemToggledOpen();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemToggledSelection();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemVisible();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyDown(int user_key_index);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyPressed(int user_key_index, byte repeat);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyPressedMap(ImGuiKey key, byte repeat);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyReleased(int user_key_index);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseClicked(ImGuiMouseButton button, byte repeat);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDoubleClicked(ImGuiMouseButton button);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDown(ImGuiMouseButton button);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDragging(ImGuiMouseButton button, float lock_threshold);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDragPastThreshold(ImGuiMouseButton button, float lock_threshold);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseHoveringRect(Vector2 r_min, Vector2 r_max, byte clip);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMousePosValid(Vector2* mouse_pos);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseReleased(ImGuiMouseButton button);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsNavInputDown(ImGuiNavInput n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsNavInputTest(ImGuiNavInput n, ImGuiInputReadMode rm);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsPopupOpenStr(byte* str_id, ImGuiPopupFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsPopupOpenID(uint id, ImGuiPopupFlags popup_flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsRectVisibleNil(Vector2 size);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsRectVisibleVec2(Vector2 rect_min, Vector2 rect_max);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowAbove(ImGuiWindow* potential_above, ImGuiWindow* potential_below);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowAppearing();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowChildOf(ImGuiWindow* window, ImGuiWindow* potential_parent);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowCollapsed();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowFocused(ImGuiFocusedFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowHovered(ImGuiHoveredFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowNavFocusable(ImGuiWindow* window);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igItemAdd(ImRect bb, uint id, ImRect* nav_bb);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igItemHoverable(ImRect bb, uint id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igItemSizeVec2(Vector2 size, float text_baseline_y);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igItemSizeRect(ImRect bb, float text_baseline_y);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igKeepAliveID(uint id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLabelText(byte* label, byte* fmt);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igListBoxStr_arr(byte* label, int* current_item, byte** items, int items_count, int height_in_items);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLoadIniSettingsFromDisk(byte* ini_filename);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLoadIniSettingsFromMemory(byte* ini_data, uint ini_size);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogBegin(ImGuiLogType type, int auto_open_depth);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogButtons();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogFinish();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogRenderedText(Vector2* ref_pos, byte* text, byte* text_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogSetNextTextDecoration(byte* prefix, byte* suffix);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogText(byte* fmt);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToBuffer(int auto_open_depth);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToClipboard(int auto_open_depth);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToFile(int auto_open_depth, byte* filename);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToTTY(int auto_open_depth);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMarkIniSettingsDirtyNil();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMarkIniSettingsDirtyWindowPtr(ImGuiWindow* window);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMarkItemEdited(uint id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* igMemAlloc(uint size);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMemFree(void* ptr);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igMenuItemBool(byte* label, byte* shortcut, byte selected, byte enabled);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igMenuItemBoolPtr(byte* label, byte* shortcut, byte* p_selected, byte enabled);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavInitWindow(ImGuiWindow* window, byte force_reinit);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igNavMoveRequestButNoResultYet();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestCancel();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestForward(ImGuiDir move_dir, ImGuiDir clip_dir, ImRect bb_rel, ImGuiNavMoveFlags move_flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestTryWrapping(ImGuiWindow* window, ImGuiNavMoveFlags move_flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNewFrame();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNewLine();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNextColumn();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igOpenPopup(byte* str_id, ImGuiPopupFlags popup_flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igOpenPopupEx(uint id, ImGuiPopupFlags popup_flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igOpenPopupOnItemClick(byte* str_id, ImGuiPopupFlags popup_flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPlotHistogramFloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPlotLinesFloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopAllowKeyboardFocus();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopButtonRepeat();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopClipRect();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopColumnsBackground();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopFocusScope();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopFont();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopID();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopItemFlag();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopItemWidth();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopStyleColor(int count);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopStyleVar(int count);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopTextWrapPos();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igProgressBar(float fraction, Vector2 size_arg, byte* overlay);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushAllowKeyboardFocus(byte allow_keyboard_focus);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushButtonRepeat(byte repeat);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushColumnClipRect(int column_index);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushColumnsBackground();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushFocusScope(uint id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushFont(ImFont* font);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushIDStr(byte* str_id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushIDStrStr(byte* str_id_begin, byte* str_id_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushIDPtr(void* ptr_id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushIDInt(int int_id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushItemFlag(ImGuiItemFlags option, byte enabled);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushItemWidth(float item_width);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushMultiItemsWidths(int components, float width_full);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushOverrideID(uint id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleColorU32(ImGuiCol idx, uint col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleColorVec4(ImGuiCol idx, Vector4 col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleVarFloat(ImGuiStyleVar idx, float val);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleVarVec2(ImGuiStyleVar idx, Vector2 val);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushTextWrapPos(float wrap_local_pos_x);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igRadioButtonBool(byte* label, byte active);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igRadioButtonIntPtr(byte* label, int* v, int v_button);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRemoveContextHook(ImGuiContext* context, uint hook_to_remove);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRender();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderArrow(ImDrawList* draw_list, Vector2 pos, uint col, ImGuiDir dir, float scale);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderArrowPointingAt(ImDrawList* draw_list, Vector2 pos, Vector2 half_sz, ImGuiDir direction, uint col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderBullet(ImDrawList* draw_list, Vector2 pos, uint col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderCheckMark(ImDrawList* draw_list, Vector2 pos, uint col, float sz);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderColorRectWithAlphaCheckerboard(ImDrawList* draw_list, Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off, float rounding, int rounding_corners_flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col, byte border, float rounding);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderFrameBorder(Vector2 p_min, Vector2 p_max, float rounding);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderMouseCursor(ImDrawList* draw_list, Vector2 pos, float scale, ImGuiMouseCursor mouse_cursor, uint col_fill, uint col_border, uint col_shadow);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderNavHighlight(ImRect bb, uint id, ImGuiNavHighlightFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderRectFilledRangeH(ImDrawList* draw_list, ImRect rect, uint col, float x_start_norm, float x_end_norm, float rounding);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderRectFilledWithHole(ImDrawList* draw_list, ImRect outer, ImRect inner, uint col, float rounding);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderText(Vector2 pos, byte* text, byte* text_end, byte hide_text_after_hash);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextClipped(Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2 align, ImRect* clip_rect);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextClippedEx(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2 align, ImRect* clip_rect);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextEllipsis(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, float clip_max_x, float ellipsis_max_x, byte* text, byte* text_end, Vector2* text_size_if_known);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextWrapped(Vector2 pos, byte* text, byte* text_end, float wrap_width);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igResetMouseDragDelta(ImGuiMouseButton button);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSameLine(float offset_from_start_x, float spacing);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSaveIniSettingsToDisk(byte* ini_filename);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igSaveIniSettingsToMemory(uint* out_ini_size);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollbar(ImGuiAxis axis);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igScrollbarEx(ImRect bb, uint id, ImGuiAxis axis, float* p_scroll_v, float avail_v, float contents_v, ImDrawCornerFlags rounding_corners);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollToBringRectIntoView(Vector2* pOut, ImGuiWindow* window, ImRect item_rect);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSelectableBool(byte* label, byte selected, ImGuiSelectableFlags flags, Vector2 size);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSelectableBoolPtr(byte* label, byte* p_selected, ImGuiSelectableFlags flags, Vector2 size);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSeparator();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSeparatorEx(ImGuiSeparatorFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetActiveID(uint id, ImGuiWindow* window);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetClipboardText(byte* text);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetColorEditOptions(ImGuiColorEditFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetColumnOffset(int column_index, float offset_x);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetColumnWidth(int column_index, float width);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCurrentContext(ImGuiContext* ctx);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCurrentFont(ImFont* font);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorPos(Vector2 local_pos);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorPosX(float local_x);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorPosY(float local_y);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorScreenPos(Vector2 pos);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSetDragDropPayload(byte* type, void* data, uint sz, ImGuiCond cond);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetFocusID(uint id, ImGuiWindow* window);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetHoveredID(uint id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetItemAllowOverlap();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetItemDefaultFocus();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetItemUsingMouseWheel();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetKeyboardFocusHere(int offset);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetLastItemData(ImGuiWindow* window, uint item_id, ImGuiItemStatusFlags status_flags, ImRect item_rect);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetMouseCursor(ImGuiMouseCursor cursor_type);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNavID(uint id, int nav_layer, uint focus_scope_id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNavIDWithRectRel(uint id, int nav_layer, uint focus_scope_id, ImRect rect_rel);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextItemOpen(byte is_open, ImGuiCond cond);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextItemWidth(float item_width);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowBgAlpha(float alpha);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowCollapsed(byte collapsed, ImGuiCond cond);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowContentSize(Vector2 size);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowFocus();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowScroll(Vector2 scroll);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowSize(Vector2 size, ImGuiCond cond);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, void* custom_callback, void* custom_callback_data);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosXFloat(float local_x, float center_x_ratio);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosXWindowPtr(ImGuiWindow* window, float local_x, float center_x_ratio);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosYFloat(float local_y, float center_y_ratio);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosYWindowPtr(ImGuiWindow* window, float local_y, float center_y_ratio);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollHereX(float center_x_ratio);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollHereY(float center_y_ratio);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollXFloat(float scroll_x);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollXWindowPtr(ImGuiWindow* window, float scroll_x);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollYFloat(float scroll_y);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollYWindowPtr(ImGuiWindow* window, float scroll_y);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetStateStorage(ImGuiStorage* storage);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetTabItemClosed(byte* tab_or_docked_window_label);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetTooltip(byte* fmt);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowClipRectBeforeSetChannel(ImGuiWindow* window, ImRect clip_rect);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowCollapsedBool(byte collapsed, ImGuiCond cond);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowCollapsedStr(byte* name, byte collapsed, ImGuiCond cond);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowCollapsedWindowPtr(ImGuiWindow* window, byte collapsed, ImGuiCond cond);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowFocusNil();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowFocusStr(byte* name);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowFontScale(float scale);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowHitTestHole(ImGuiWindow* window, Vector2 pos, Vector2 size);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowPosVec2(Vector2 pos, ImGuiCond cond);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowPosStr(byte* name, Vector2 pos, ImGuiCond cond);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowPosWindowPtr(ImGuiWindow* window, Vector2 pos, ImGuiCond cond);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowSizeVec2(Vector2 size, ImGuiCond cond);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowSizeStr(byte* name, Vector2 size, ImGuiCond cond);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowSizeWindowPtr(ImGuiWindow* window, Vector2 size, ImGuiCond cond);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShadeVertsLinearColorGradientKeepAlpha(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 gradient_p0, Vector2 gradient_p1, uint col0, uint col1);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShadeVertsLinearUV(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, byte clamp);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowAboutWindow(byte* p_open);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowDemoWindow(byte* p_open);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowFontSelector(byte* label);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowMetricsWindow(byte* p_open);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowStyleEditor(ImGuiStyle* @ref);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igShowStyleSelector(byte* label);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowUserGuide();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShrinkWidths(ImGuiShrinkWidthItem* items, int count, float width_excess);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShutdown(ImGuiContext* context);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderAngle(byte* label, float* v_rad, float v_degrees_min, float v_degrees_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderBehavior(ImRect bb, uint id, ImGuiDataType data_type, void* p_v, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags, ImRect* out_grab_bb);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat(byte* label, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat2(byte* label, Vector2* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat3(byte* label, Vector3* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat4(byte* label, Vector4* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt2(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt3(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt4(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSmallButton(byte* label);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSpacing();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, float* size1, float* size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStartMouseMovingWindow(ImGuiWindow* window);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStyleColorsClassic(ImGuiStyle* dst);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStyleColorsDark(ImGuiStyle* dst);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStyleColorsLight(ImGuiStyle* dst);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarCloseTab(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabItem* igTabBarFindTabByID(ImGuiTabBar* tab_bar, uint tab_id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTabBarProcessReorder(ImGuiTabBar* tab_bar);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarQueueReorder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, int dir);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarRemoveTab(ImGuiTabBar* tab_bar, uint tab_id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabItemBackground(ImDrawList* draw_list, ImRect bb, ImGuiTabItemFlags flags, uint col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTabItemButton(byte* label, ImGuiTabItemFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabItemCalcSize(Vector2* pOut, byte* label, byte has_close_button);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTabItemEx(ImGuiTabBar* tab_bar, byte* label, byte* p_open, ImGuiTabItemFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabItemLabelAndCloseButton(ImDrawList* draw_list, ImRect bb, ImGuiTabItemFlags flags, Vector2 frame_padding, byte* label, uint tab_id, uint close_button_id, byte is_contents_visible, byte* out_just_closed, byte* out_text_clipped);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableBeginApplyRequests(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableBeginCell(ImGuiTable* table, int column_n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableBeginInitMemory(ImGuiTable* table, int columns_count);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableBeginRow(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableDrawBorders(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableDrawContextMenu(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableEndCell(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableEndRow(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTable* igTableFindByID(uint id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableFixColumnSortDirection(ImGuiTable* table, ImGuiTableColumn* column);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableGcCompactSettings();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableGcCompactTransientBuffers(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSettings* igTableGetBoundSettings(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableGetCellBgRect(ImRect* pOut, ImGuiTable* table, int column_n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTableGetColumnCount();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumnFlags igTableGetColumnFlags(int column_n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTableGetColumnIndex();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igTableGetColumnNameInt(int column_n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igTableGetColumnNameTablePtr(ImGuiTable* table, int column_n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiSortDirection igTableGetColumnNextSortDirection(ImGuiTableColumn* column);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igTableGetColumnResizeID(ImGuiTable* table, int column_n, int instance_no);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igTableGetColumnWidthAuto(ImGuiTable* table, ImGuiTableColumn* column);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igTableGetHeaderRowHeight();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTableGetHoveredColumn();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igTableGetMaxColumnWidth(ImGuiTable* table, int column_n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTableGetRowIndex();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSortSpecs* igTableGetSortSpecs();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableHeader(byte* label);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableHeadersRow();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableLoadSettings(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableMergeDrawChannels(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTableNextColumn();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableNextRow(ImGuiTableRowFlags row_flags, float min_row_height);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableOpenContextMenu(int column_n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTablePopBackgroundChannel();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTablePushBackgroundChannel();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableRemove(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableResetSettings(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSaveSettings(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetBgColor(ImGuiTableBgTarget target, uint color, int column_n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetColumnEnabled(int column_n, byte enabled);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTableSetColumnIndex(int column_n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetColumnSortDirection(int column_n, ImGuiSortDirection sort_direction, byte append_to_sort_specs);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetColumnWidth(int column_n, float width);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetColumnWidthAutoAll(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetColumnWidthAutoSingle(ImGuiTable* table, int column_n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSettings* igTableSettingsCreate(uint id, int columns_count);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSettings* igTableSettingsFindByID(uint id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSettingsInstallHandler(ImGuiContext* context);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetupColumn(byte* label, ImGuiTableColumnFlags flags, float init_width_or_weight, uint user_id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetupDrawChannels(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetupScrollFreeze(int cols, int rows);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSortSpecsBuild(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSortSpecsSanitize(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableUpdateBorders(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableUpdateColumnsWeightFromWidth(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableUpdateLayout(ImGuiTable* table);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTempInputIsActive(uint id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTempInputScalar(ImRect bb, uint id, byte* label, ImGuiDataType data_type, void* p_data, byte* format, void* p_clamp_min, void* p_clamp_max);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTempInputText(ImRect bb, uint id, byte* label, byte* buf, int buf_size, ImGuiInputTextFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igText(byte* fmt);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextColored(Vector4 col, byte* fmt);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextDisabled(byte* fmt);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextEx(byte* text, byte* text_end, ImGuiTextFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextUnformatted(byte* text, byte* text_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextWrapped(byte* fmt);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeStr(byte* label);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeStrStr(byte* str_id, byte* fmt);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodePtr(void* ptr_id, byte* fmt);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, byte* label, byte* label_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeBehaviorIsOpen(uint id, ImGuiTreeNodeFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeExStr(byte* label, ImGuiTreeNodeFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeExStrStr(byte* str_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeExPtr(void* ptr_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePop();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePushStr(byte* str_id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePushPtr(void* ptr_id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePushOverrideID(uint id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUnindent(float indent_w);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateHoveredWindowAndCaptureFlags();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateMouseMovingWindowEndFrame();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateMouseMovingWindowNewFrame();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateWindowParentAndRootLinks(ImGuiWindow* window, ImGuiWindowFlags flags, ImGuiWindow* parent_window);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValueBool(byte* prefix, byte b);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValueInt(byte* prefix, int v);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValueUint(byte* prefix, uint v);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValueFloat(byte* prefix, float v, byte* float_format);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igVSliderFloat(byte* label, Vector2 size, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igVSliderInt(byte* label, Vector2 size, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igVSliderScalar(byte* label, Vector2 size, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImBitVector_Clear(ImBitVector* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImBitVector_ClearBit(ImBitVector* self, int n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImBitVector_Create(ImBitVector* self, int sz);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImBitVector_SetBit(ImBitVector* self, int n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImBitVector_TestBit(ImBitVector* self, int n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_destroy(ImColor* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_HSV(ImColor* pOut, float h, float s, float v, float a);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorNil();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorInt(int r, int g, int b, int a);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorU32(uint rgba);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorFloat(float r, float g, float b, float a);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorVec4(Vector4 col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_SetHSV(ImColor* self, float h, float s, float v, float a);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawCmd_destroy(ImDrawCmd* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawCmd* ImDrawCmd_ImDrawCmd();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_Clear(ImDrawData* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_DeIndexAllBuffers(ImDrawData* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_destroy(ImDrawData* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawData* ImDrawData_ImDrawData();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_ScaleClipRects(ImDrawData* self, Vector2 fb_scale);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawDataBuilder_Clear(ImDrawDataBuilder* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawDataBuilder_ClearFreeMemory(ImDrawDataBuilder* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawDataBuilder_FlattenIntoSingleLayer(ImDrawDataBuilder* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImDrawDataBuilder_GetDrawListCount(ImDrawDataBuilder* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__ClearFreeMemory(ImDrawList* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__OnChangedClipRect(ImDrawList* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__OnChangedTextureID(ImDrawList* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__OnChangedVtxOffset(ImDrawList* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__PopUnusedDrawCmd(ImDrawList* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__ResetForNewFrame(ImDrawList* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddBezierCubic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int num_segments);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddBezierQuadratic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness, int num_segments);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCallback(ImDrawList* self, void* callback, void* callback_data);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCircle(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCircleFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddConvexPolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddDrawCmd(ImDrawList* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImage(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImageQuad(ImDrawList* self, IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImageRounded(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding, ImDrawCornerFlags rounding_corners);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddLine(ImDrawList* self, Vector2 p1, Vector2 p2, uint col, float thickness);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddNgon(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddNgonFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddPolyline(ImDrawList* self, Vector2* points, int num_points, uint col, byte closed, float thickness);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddQuad(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddQuadFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRect(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawCornerFlags rounding_corners, float thickness);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRectFilled(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawCornerFlags rounding_corners);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRectFilledMultiColor(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTextVec2(ImDrawList* self, Vector2 pos, uint col, byte* text_begin, byte* text_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTextFontPtr(ImDrawList* self, ImFont* font, float font_size, Vector2 pos, uint col, byte* text_begin, byte* text_end, float wrap_width, Vector4* cpu_fine_clip_rect);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTriangle(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTriangleFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsMerge(ImDrawList* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsSetCurrent(ImDrawList* self, int n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsSplit(ImDrawList* self, int count);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImDrawList_CloneOutput(ImDrawList* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_destroy(ImDrawList* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_GetClipRectMax(Vector2* pOut, ImDrawList* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_GetClipRectMin(Vector2* pOut, ImDrawList* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImDrawList_ImDrawList(IntPtr shared_data);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathArcTo(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathArcToFast(ImDrawList* self, Vector2 center, float radius, int a_min_of_12, int a_max_of_12);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathBezierCubicCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, Vector2 p4, int num_segments);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathBezierQuadraticCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, int num_segments);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathClear(ImDrawList* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathFillConvex(ImDrawList* self, uint col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathLineTo(ImDrawList* self, Vector2 pos);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathLineToMergeDuplicate(ImDrawList* self, Vector2 pos);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathRect(ImDrawList* self, Vector2 rect_min, Vector2 rect_max, float rounding, ImDrawCornerFlags rounding_corners);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathStroke(ImDrawList* self, uint col, byte closed, float thickness);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PopClipRect(ImDrawList* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PopTextureID(ImDrawList* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimQuadUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimRect(ImDrawList* self, Vector2 a, Vector2 b, uint col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimRectUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimReserve(ImDrawList* self, int idx_count, int vtx_count);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimUnreserve(ImDrawList* self, int idx_count, int vtx_count);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimWriteIdx(ImDrawList* self, ushort idx);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimWriteVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushClipRect(ImDrawList* self, Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushClipRectFullScreen(ImDrawList* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushTextureID(ImDrawList* self, IntPtr texture_id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSharedData_destroy(IntPtr self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImDrawListSharedData_ImDrawListSharedData();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSharedData_SetCircleSegmentMaxError(IntPtr self, float max_error);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Clear(ImDrawListSplitter* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_ClearFreeMemory(ImDrawListSplitter* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_destroy(ImDrawListSplitter* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawListSplitter* ImDrawListSplitter_ImDrawListSplitter();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Merge(ImDrawListSplitter* self, ImDrawList* draw_list);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_SetCurrentChannel(ImDrawListSplitter* self, ImDrawList* draw_list, int channel_idx);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Split(ImDrawListSplitter* self, ImDrawList* draw_list, int count);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_AddGlyph(ImFont* self, ImFontConfig* src_cfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_AddRemapChar(ImFont* self, ushort dst, ushort src, byte overwrite_dst);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_BuildLookupTable(ImFont* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_CalcTextSizeA(Vector2* pOut, ImFont* self, float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, byte** remaining);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImFont_CalcWordWrapPositionA(ImFont* self, float scale, byte* text, byte* text_end, float wrap_width);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_ClearOutputData(ImFont* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_destroy(ImFont* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyph* ImFont_FindGlyph(ImFont* self, ushort c);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyph* ImFont_FindGlyphNoFallback(ImFont* self, ushort c);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImFont_GetCharAdvance(ImFont* self, ushort c);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImFont_GetDebugName(ImFont* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_GrowIndex(ImFont* self, int new_size);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFont_ImFont();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFont_IsGlyphRangeUnused(ImFont* self, uint c_begin, uint c_last);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFont_IsLoaded(ImFont* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_RenderChar(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, ushort c);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_RenderText(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, byte* text_begin, byte* text_end, float wrap_width, byte cpu_fine_clip);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_SetFallbackChar(ImFont* self, ushort c);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_SetGlyphVisible(ImFont* self, ushort c, byte visible);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImFontAtlas_AddCustomRectFontGlyph(ImFontAtlas* self, ImFont* font, ushort id, int width, int height, float advance_x, Vector2 offset);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImFontAtlas_AddCustomRectRegular(ImFontAtlas* self, int width, int height);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFont(ImFontAtlas* self, ImFontConfig* font_cfg);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* self, ImFontConfig* font_cfg);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* self, byte* filename, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, byte* compressed_font_data_base85, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* self, void* compressed_font_data, int compressed_font_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* self, void* font_data, int font_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_Build(ImFontAtlas* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_CalcCustomRectUV(ImFontAtlas* self, ImFontAtlasCustomRect* rect, Vector2* out_uv_min, Vector2* out_uv_max);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_Clear(ImFontAtlas* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearFonts(ImFontAtlas* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearInputData(ImFontAtlas* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearTexData(ImFontAtlas* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_destroy(ImFontAtlas* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlasCustomRect* ImFontAtlas_GetCustomRectByIndex(ImFontAtlas* self, int index);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesChineseFull(ImFontAtlas* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesCyrillic(ImFontAtlas* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesDefault(ImFontAtlas* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesJapanese(ImFontAtlas* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesKorean(ImFontAtlas* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesThai(ImFontAtlas* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesVietnamese(ImFontAtlas* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_GetMouseCursorTexData(ImFontAtlas* self, ImGuiMouseCursor cursor, Vector2* out_offset, Vector2* out_size, Vector2* out_uv_border, Vector2* out_uv_fill);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, IntPtr* out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, IntPtr* out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlas* ImFontAtlas_ImFontAtlas();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_IsBuilt(ImFontAtlas* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_SetTexID(ImFontAtlas* self, IntPtr id);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlasCustomRect_destroy(ImFontAtlasCustomRect* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlasCustomRect* ImFontAtlasCustomRect_ImFontAtlasCustomRect();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlasCustomRect_IsPacked(ImFontAtlasCustomRect* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontConfig_destroy(ImFontConfig* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontConfig* ImFontConfig_ImFontConfig();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddChar(ImFontGlyphRangesBuilder* self, ushort c);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddRanges(ImFontGlyphRangesBuilder* self, ushort* ranges);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddText(ImFontGlyphRangesBuilder* self, byte* text, byte* text_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_BuildRanges(ImFontGlyphRangesBuilder* self, ImVector* out_ranges);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_Clear(ImFontGlyphRangesBuilder* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_destroy(ImFontGlyphRangesBuilder* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontGlyphRangesBuilder_GetBit(ImFontGlyphRangesBuilder* self, uint n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyphRangesBuilder* ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_SetBit(ImFontGlyphRangesBuilder* self, uint n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiContext_destroy(ImGuiContext* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiContext* ImGuiContext_ImGuiContext(ImFontAtlas* shared_font_atlas);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiContextHook_destroy(ImGuiContextHook* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiContextHook* ImGuiContextHook_ImGuiContextHook();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_ClearSelection(ImGuiInputTextCallbackData* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_DeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytes_count);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_destroy(ImGuiInputTextCallbackData* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiInputTextCallbackData_HasSelection(ImGuiInputTextCallbackData* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiInputTextCallbackData* ImGuiInputTextCallbackData_ImGuiInputTextCallbackData();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_InsertChars(ImGuiInputTextCallbackData* self, int pos, byte* text, byte* text_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_SelectAll(ImGuiInputTextCallbackData* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_ClearFreeMemory(ImGuiInputTextState* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_ClearSelection(ImGuiInputTextState* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_ClearText(ImGuiInputTextState* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_CursorAnimReset(ImGuiInputTextState* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_CursorClamp(ImGuiInputTextState* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_destroy(ImGuiInputTextState* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiInputTextState_GetRedoAvailCount(ImGuiInputTextState* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiInputTextState_GetUndoAvailCount(ImGuiInputTextState* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiInputTextState_HasSelection(ImGuiInputTextState* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiInputTextState* ImGuiInputTextState_ImGuiInputTextState();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_OnKeyPressed(ImGuiInputTextState* self, int key);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_SelectAll(ImGuiInputTextState* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharacter(ImGuiIO* self, uint c);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharactersUTF8(ImGuiIO* self, byte* str);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharacterUTF16(ImGuiIO* self, ushort c);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_ClearInputCharacters(ImGuiIO* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_destroy(ImGuiIO* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiIO* ImGuiIO_ImGuiIO();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiLastItemDataBackup_Backup(ImGuiLastItemDataBackup* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiLastItemDataBackup_destroy(ImGuiLastItemDataBackup* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiLastItemDataBackup* ImGuiLastItemDataBackup_ImGuiLastItemDataBackup();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiLastItemDataBackup_Restore(ImGuiLastItemDataBackup* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_Begin(ImGuiListClipper* self, int items_count, float items_height);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_destroy(ImGuiListClipper* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_End(ImGuiListClipper* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiListClipper* ImGuiListClipper_ImGuiListClipper();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiListClipper_Step(ImGuiListClipper* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiMenuColumns_CalcExtraSpace(ImGuiMenuColumns* self, float avail_w);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiMenuColumns_DeclColumns(ImGuiMenuColumns* self, float w0, float w1, float w2);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiMenuColumns_destroy(ImGuiMenuColumns* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiMenuColumns* ImGuiMenuColumns_ImGuiMenuColumns();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiMenuColumns_Update(ImGuiMenuColumns* self, int count, float spacing, byte clear);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiMetricsConfig_destroy(ImGuiMetricsConfig* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiMetricsConfig* ImGuiMetricsConfig_ImGuiMetricsConfig();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNavMoveResult_Clear(ImGuiNavMoveResult* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNavMoveResult_destroy(ImGuiNavMoveResult* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiNavMoveResult* ImGuiNavMoveResult_ImGuiNavMoveResult();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNextItemData_ClearFlags(ImGuiNextItemData* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNextItemData_destroy(ImGuiNextItemData* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiNextItemData* ImGuiNextItemData_ImGuiNextItemData();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNextWindowData_ClearFlags(ImGuiNextWindowData* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNextWindowData_destroy(ImGuiNextWindowData* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiNextWindowData* ImGuiNextWindowData_ImGuiNextWindowData();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiOldColumnData_destroy(ImGuiOldColumnData* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiOldColumnData* ImGuiOldColumnData_ImGuiOldColumnData();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiOldColumns_destroy(ImGuiOldColumns* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiOldColumns* ImGuiOldColumns_ImGuiOldColumns();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiOnceUponAFrame_destroy(ImGuiOnceUponAFrame* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiOnceUponAFrame* ImGuiOnceUponAFrame_ImGuiOnceUponAFrame();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPayload_Clear(ImGuiPayload* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPayload_destroy(ImGuiPayload* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* ImGuiPayload_ImGuiPayload();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsDataType(ImGuiPayload* self, byte* type);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsDelivery(ImGuiPayload* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsPreview(ImGuiPayload* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPopupData_destroy(ImGuiPopupData* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPopupData* ImGuiPopupData_ImGuiPopupData();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPtrOrIndex_destroy(ImGuiPtrOrIndex* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPtrOrIndex* ImGuiPtrOrIndex_ImGuiPtrOrIndexPtr(void* ptr);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPtrOrIndex* ImGuiPtrOrIndex_ImGuiPtrOrIndexInt(int index);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiSettingsHandler_destroy(ImGuiSettingsHandler* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiSettingsHandler* ImGuiSettingsHandler_ImGuiSettingsHandler();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStackSizes_CompareWithCurrentState(ImGuiStackSizes* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStackSizes_destroy(ImGuiStackSizes* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStackSizes* ImGuiStackSizes_ImGuiStackSizes();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStackSizes_SetToCurrentState(ImGuiStackSizes* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_BuildSortByKey(ImGuiStorage* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_Clear(ImGuiStorage* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiStorage_GetBool(ImGuiStorage* self, uint key, byte default_val);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiStorage_GetBoolRef(ImGuiStorage* self, uint key, byte default_val);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiStorage_GetFloat(ImGuiStorage* self, uint key, float default_val);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float* ImGuiStorage_GetFloatRef(ImGuiStorage* self, uint key, float default_val);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiStorage_GetInt(ImGuiStorage* self, uint key, int default_val);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* ImGuiStorage_GetIntRef(ImGuiStorage* self, uint key, int default_val);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* ImGuiStorage_GetVoidPtr(ImGuiStorage* self, uint key);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void** ImGuiStorage_GetVoidPtrRef(ImGuiStorage* self, uint key, void* default_val);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetAllInt(ImGuiStorage* self, int val);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetBool(ImGuiStorage* self, uint key, byte val);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetFloat(ImGuiStorage* self, uint key, float val);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetInt(ImGuiStorage* self, uint key, int val);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetVoidPtr(ImGuiStorage* self, uint key, void* val);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStoragePair_destroy(ImGuiStoragePair* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePairInt(uint _key, int _val_i);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePairFloat(uint _key, float _val_f);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePairPtr(uint _key, void* _val_p);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStyle_destroy(ImGuiStyle* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle* ImGuiStyle_ImGuiStyle();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStyle_ScaleAllSizes(ImGuiStyle* self, float scale_factor);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStyleMod_destroy(ImGuiStyleMod* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyleMod* ImGuiStyleMod_ImGuiStyleModInt(ImGuiStyleVar idx, int v);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyleMod* ImGuiStyleMod_ImGuiStyleModFloat(ImGuiStyleVar idx, float v);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyleMod* ImGuiStyleMod_ImGuiStyleModVec2(ImGuiStyleVar idx, Vector2 v);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTabBar_destroy(ImGuiTabBar* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTabBar_GetTabName(ImGuiTabBar* self, ImGuiTabItem* tab);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiTabBar_GetTabOrder(ImGuiTabBar* self, ImGuiTabItem* tab);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabBar* ImGuiTabBar_ImGuiTabBar();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTabItem_destroy(ImGuiTabItem* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabItem* ImGuiTabItem_ImGuiTabItem();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTable_destroy(ImGuiTable* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTable* ImGuiTable_ImGuiTable();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableColumn_destroy(ImGuiTableColumn* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumn* ImGuiTableColumn_ImGuiTableColumn();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableColumnSettings_destroy(ImGuiTableColumnSettings* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumnSettings* ImGuiTableColumnSettings_ImGuiTableColumnSettings();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableColumnSortSpecs_destroy(ImGuiTableColumnSortSpecs* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumnSortSpecs* ImGuiTableColumnSortSpecs_ImGuiTableColumnSortSpecs();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableSettings_destroy(ImGuiTableSettings* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumnSettings* ImGuiTableSettings_GetColumnSettings(ImGuiTableSettings* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSettings* ImGuiTableSettings_ImGuiTableSettings();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableSortSpecs_destroy(ImGuiTableSortSpecs* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSortSpecs* ImGuiTableSortSpecs_ImGuiTableSortSpecs();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_append(ImGuiTextBuffer* self, byte* str, byte* str_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_appendf(ImGuiTextBuffer* self, byte* fmt);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_begin(ImGuiTextBuffer* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_c_str(ImGuiTextBuffer* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_clear(ImGuiTextBuffer* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_destroy(ImGuiTextBuffer* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextBuffer_empty(ImGuiTextBuffer* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_end(ImGuiTextBuffer* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextBuffer* ImGuiTextBuffer_ImGuiTextBuffer();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_reserve(ImGuiTextBuffer* self, int capacity);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiTextBuffer_size(ImGuiTextBuffer* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_Build(ImGuiTextFilter* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_Clear(ImGuiTextFilter* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_destroy(ImGuiTextFilter* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_Draw(ImGuiTextFilter* self, byte* label, float width);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextFilter* ImGuiTextFilter_ImGuiTextFilter(byte* default_filter);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_IsActive(ImGuiTextFilter* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_PassFilter(ImGuiTextFilter* self, byte* text, byte* text_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextRange_destroy(ImGuiTextRange* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextRange_empty(ImGuiTextRange* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextRange* ImGuiTextRange_ImGuiTextRangeNil();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextRange* ImGuiTextRange_ImGuiTextRangeStr(byte* _b, byte* _e);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextRange_split(ImGuiTextRange* self, byte separator, ImVector* @out);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewport_destroy(ImGuiViewport* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewport_GetCenter(Vector2* pOut, ImGuiViewport* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewport_GetWorkCenter(Vector2* pOut, ImGuiViewport* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* ImGuiViewport_ImGuiViewport();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_destroy(ImGuiViewportP* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_GetMainRect(ImRect* pOut, ImGuiViewportP* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_GetWorkRect(ImRect* pOut, ImGuiViewportP* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewportP* ImGuiViewportP_ImGuiViewportP();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_UpdateWorkRect(ImGuiViewportP* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiWindow_CalcFontSize(ImGuiWindow* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindow_destroy(ImGuiWindow* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetIDStr(ImGuiWindow* self, byte* str, byte* str_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetIDPtr(ImGuiWindow* self, void* ptr);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetIDInt(ImGuiWindow* self, int n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetIDFromRectangle(ImGuiWindow* self, ImRect r_abs);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetIDNoKeepAliveStr(ImGuiWindow* self, byte* str, byte* str_end);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetIDNoKeepAlivePtr(ImGuiWindow* self, void* ptr);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetIDNoKeepAliveInt(ImGuiWindow* self, int n);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* ImGuiWindow_ImGuiWindow(ImGuiContext* context, byte* name);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiWindow_MenuBarHeight(ImGuiWindow* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindow_MenuBarRect(ImRect* pOut, ImGuiWindow* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindow_Rect(ImRect* pOut, ImGuiWindow* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiWindow_TitleBarHeight(ImGuiWindow* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindow_TitleBarRect(ImRect* pOut, ImGuiWindow* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindowSettings_destroy(ImGuiWindowSettings* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiWindowSettings_GetName(ImGuiWindowSettings* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* ImGuiWindowSettings_ImGuiWindowSettings();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_AddVec2(ImRect* self, Vector2 p);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_AddRect(ImRect* self, ImRect r);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_ClipWith(ImRect* self, ImRect r);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_ClipWithFull(ImRect* self, ImRect r);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImRect_ContainsVec2(ImRect* self, Vector2 p);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImRect_ContainsRect(ImRect* self, ImRect r);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_destroy(ImRect* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_ExpandFloat(ImRect* self, float amount);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_ExpandVec2(ImRect* self, Vector2 amount);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_Floor(ImRect* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetBL(Vector2* pOut, ImRect* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetBR(Vector2* pOut, ImRect* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetCenter(Vector2* pOut, ImRect* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImRect_GetHeight(ImRect* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetSize(Vector2* pOut, ImRect* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetTL(Vector2* pOut, ImRect* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetTR(Vector2* pOut, ImRect* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImRect_GetWidth(ImRect* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImRect* ImRect_ImRectNil();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImRect* ImRect_ImRectVec2(Vector2 min, Vector2 max);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImRect* ImRect_ImRectVec4(Vector4 v);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImRect* ImRect_ImRectFloat(float x1, float y1, float x2, float y2);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImRect_IsInverted(ImRect* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImRect_Overlaps(ImRect* self, ImRect r);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_ToVec4(Vector4* pOut, ImRect* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_Translate(ImRect* self, Vector2 d);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_TranslateX(ImRect* self, float dx);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_TranslateY(ImRect* self, float dy);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec1_destroy(ImVec1* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec1* ImVec1_ImVec1Nil();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec1* ImVec1_ImVec1Float(float _x);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec2_destroy(Vector2* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2* ImVec2_ImVec2Nil();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2* ImVec2_ImVec2Float(float _x, float _y);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec2ih_destroy(ImVec2ih* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec2ih* ImVec2ih_ImVec2ihNil();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec2ih* ImVec2ih_ImVec2ihshort(short _x, short _y);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec2ih* ImVec2ih_ImVec2ihVec2(Vector2 rhs);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec4_destroy(Vector4* self);
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* ImVec4_ImVec4Nil();
        [SuppressGCTransition]
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* ImVec4_ImVec4Float(float _x, float _y, float _z, float _w);
    }
}
