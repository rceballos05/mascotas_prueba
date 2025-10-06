#define ICALL_TABLE_corlib 1

static int corlib_icall_indexes [] = {
177,
189,
190,
191,
192,
193,
194,
195,
196,
197,
200,
201,
202,
375,
376,
377,
406,
407,
408,
428,
429,
430,
431,
548,
549,
550,
553,
595,
596,
597,
598,
599,
604,
606,
608,
610,
615,
623,
624,
625,
626,
627,
628,
629,
630,
631,
632,
633,
634,
635,
636,
637,
638,
639,
641,
642,
643,
644,
645,
646,
647,
741,
742,
743,
744,
745,
746,
747,
748,
749,
750,
751,
752,
753,
754,
755,
756,
757,
759,
760,
761,
762,
763,
764,
765,
832,
833,
901,
908,
911,
913,
918,
919,
921,
922,
926,
927,
929,
931,
932,
935,
936,
937,
940,
942,
945,
947,
949,
958,
1025,
1027,
1029,
1039,
1040,
1041,
1042,
1044,
1051,
1052,
1053,
1054,
1055,
1063,
1064,
1065,
1069,
1070,
1072,
1076,
1077,
1078,
1362,
1553,
1554,
9235,
9236,
9238,
9239,
9240,
9241,
9242,
9244,
9246,
9248,
9249,
9250,
9261,
9263,
9268,
9270,
9272,
9274,
9325,
9326,
9328,
9329,
9330,
9331,
9332,
9334,
9336,
10445,
10449,
10451,
10452,
10453,
10454,
10633,
10634,
10635,
10636,
10655,
10656,
10657,
10659,
10661,
10662,
10793,
10795,
10797,
10807,
10808,
10809,
10810,
10811,
11271,
11272,
11273,
11278,
11279,
11314,
11334,
11341,
11348,
11359,
11363,
11388,
11468,
11470,
11481,
11483,
11484,
11485,
11492,
11506,
11526,
11527,
11535,
11537,
11544,
11545,
11548,
11550,
11555,
11561,
11562,
11569,
11571,
11583,
11586,
11587,
11588,
11599,
11608,
11614,
11615,
11616,
11618,
11619,
11636,
11638,
11652,
11674,
11675,
11676,
11701,
11706,
11736,
11737,
12291,
12305,
12400,
12401,
12616,
12617,
12625,
12626,
12627,
12633,
12732,
13312,
13313,
13885,
13886,
13887,
13892,
13902,
14855,
14876,
14878,
14880,
};
void ves_icall_System_Array_InternalCreate (int,int,int,int,int);
int ves_icall_System_Array_GetCorElementTypeOfElementTypeInternal (int);
int ves_icall_System_Array_IsValueOfElementTypeInternal (int,int);
int ves_icall_System_Array_CanChangePrimitive (int,int,int);
int ves_icall_System_Array_FastCopy (int,int,int,int,int);
int ves_icall_System_Array_GetLengthInternal_raw (int,int,int);
int ves_icall_System_Array_GetLowerBoundInternal_raw (int,int,int);
void ves_icall_System_Array_GetGenericValue_icall (int,int,int);
void ves_icall_System_Array_GetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_SetGenericValue_icall (int,int,int);
void ves_icall_System_Array_SetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_InitializeInternal_raw (int,int);
void ves_icall_System_Array_SetValueRelaxedImpl_raw (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_ZeroMemory (int,int);
void ves_icall_System_Runtime_RuntimeImports_Memmove (int,int,int);
void ves_icall_System_Buffer_BulkMoveWithWriteBarrier (int,int,int,int);
int ves_icall_System_Delegate_AllocDelegateLike_internal_raw (int,int);
int ves_icall_System_Delegate_CreateDelegate_internal_raw (int,int,int,int,int);
int ves_icall_System_Delegate_GetVirtualMethod_internal_raw (int,int);
void ves_icall_System_Enum_GetEnumValuesAndNames_raw (int,int,int,int);
void ves_icall_System_Enum_InternalBoxEnum_raw (int,int,int64_t,int);
int ves_icall_System_Enum_InternalGetCorElementType (int);
void ves_icall_System_Enum_InternalGetUnderlyingType_raw (int,int,int);
int ves_icall_System_Environment_get_ProcessorCount ();
int ves_icall_System_Environment_get_TickCount ();
int64_t ves_icall_System_Environment_get_TickCount64 ();
void ves_icall_System_Environment_FailFast_raw (int,int,int,int);
int ves_icall_System_GC_GetCollectionCount (int);
void ves_icall_System_GC_AddPressure (uint64_t);
void ves_icall_System_GC_RemovePressure (uint64_t);
void ves_icall_System_GC_register_ephemeron_array_raw (int,int);
int ves_icall_System_GC_get_ephemeron_tombstone_raw (int);
void ves_icall_System_GC_SuppressFinalize_raw (int,int);
void ves_icall_System_GC_ReRegisterForFinalize_raw (int,int);
void ves_icall_System_GC_GetGCMemoryInfo (int,int,int,int,int,int);
int ves_icall_System_GC_AllocPinnedArray_raw (int,int,int);
int ves_icall_System_Object_MemberwiseClone_raw (int,int);
double ves_icall_System_Math_Acos (double);
double ves_icall_System_Math_Acosh (double);
double ves_icall_System_Math_Asin (double);
double ves_icall_System_Math_Asinh (double);
double ves_icall_System_Math_Atan (double);
double ves_icall_System_Math_Atan2 (double,double);
double ves_icall_System_Math_Atanh (double);
double ves_icall_System_Math_Cbrt (double);
double ves_icall_System_Math_Ceiling (double);
double ves_icall_System_Math_Cos (double);
double ves_icall_System_Math_Cosh (double);
double ves_icall_System_Math_Exp (double);
double ves_icall_System_Math_Floor (double);
double ves_icall_System_Math_Log (double);
double ves_icall_System_Math_Log10 (double);
double ves_icall_System_Math_Pow (double,double);
double ves_icall_System_Math_Sin (double);
double ves_icall_System_Math_Sinh (double);
double ves_icall_System_Math_Sqrt (double);
double ves_icall_System_Math_Tan (double);
double ves_icall_System_Math_Tanh (double);
double ves_icall_System_Math_FusedMultiplyAdd (double,double,double);
double ves_icall_System_Math_Log2 (double);
double ves_icall_System_Math_ModF (double,int);
float ves_icall_System_MathF_Acos (float);
float ves_icall_System_MathF_Acosh (float);
float ves_icall_System_MathF_Asin (float);
float ves_icall_System_MathF_Asinh (float);
float ves_icall_System_MathF_Atan (float);
float ves_icall_System_MathF_Atan2 (float,float);
float ves_icall_System_MathF_Atanh (float);
float ves_icall_System_MathF_Cbrt (float);
float ves_icall_System_MathF_Ceiling (float);
float ves_icall_System_MathF_Cos (float);
float ves_icall_System_MathF_Cosh (float);
float ves_icall_System_MathF_Exp (float);
float ves_icall_System_MathF_Floor (float);
float ves_icall_System_MathF_Log (float);
float ves_icall_System_MathF_Log10 (float);
float ves_icall_System_MathF_Pow (float,float);
float ves_icall_System_MathF_Sin (float);
float ves_icall_System_MathF_Sinh (float);
float ves_icall_System_MathF_Sqrt (float);
float ves_icall_System_MathF_Tan (float);
float ves_icall_System_MathF_Tanh (float);
float ves_icall_System_MathF_FusedMultiplyAdd (float,float,float);
float ves_icall_System_MathF_Log2 (float);
float ves_icall_System_MathF_ModF (float,int);
void ves_icall_RuntimeMethodHandle_ReboxFromNullable_raw (int,int,int);
void ves_icall_RuntimeMethodHandle_ReboxToNullable_raw (int,int,int,int);
int ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw (int,int,int);
void ves_icall_RuntimeType_make_array_type_raw (int,int,int,int);
void ves_icall_RuntimeType_make_byref_type_raw (int,int,int);
void ves_icall_RuntimeType_make_pointer_type_raw (int,int,int);
void ves_icall_RuntimeType_MakeGenericType_raw (int,int,int,int);
int ves_icall_RuntimeType_GetMethodsByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetPropertiesByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetConstructors_native_raw (int,int,int);
int ves_icall_System_RuntimeType_CreateInstanceInternal_raw (int,int);
void ves_icall_System_RuntimeType_AllocateValueType_raw (int,int,int,int);
void ves_icall_RuntimeType_GetDeclaringMethod_raw (int,int,int);
void ves_icall_System_RuntimeType_getFullName_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetGenericArgumentsInternal_raw (int,int,int,int);
int ves_icall_RuntimeType_GetGenericParameterPosition (int);
int ves_icall_RuntimeType_GetEvents_native_raw (int,int,int,int);
int ves_icall_RuntimeType_GetFields_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetInterfaces_raw (int,int,int);
int ves_icall_RuntimeType_GetNestedTypes_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetDeclaringType_raw (int,int,int);
void ves_icall_RuntimeType_GetName_raw (int,int,int);
void ves_icall_RuntimeType_GetNamespace_raw (int,int,int);
int ves_icall_RuntimeType_FunctionPointerReturnAndParameterTypes_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetAttributes (int);
int ves_icall_RuntimeTypeHandle_GetMetadataToken_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_GetCorElementType (int);
int ves_icall_RuntimeTypeHandle_HasInstantiation (int);
int ves_icall_RuntimeTypeHandle_IsComObject_raw (int,int);
int ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_HasReferences_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetArrayRank_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetAssembly_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetElementType_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetModule_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetBaseType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition (int);
int ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw (int,int);
int ves_icall_RuntimeTypeHandle_is_subclass_of_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsByRefLike_raw (int,int);
void ves_icall_System_RuntimeTypeHandle_internal_from_name_raw (int,int,int,int,int,int);
int ves_icall_System_String_FastAllocateString_raw (int,int);
int ves_icall_System_String_InternalIsInterned_raw (int,int);
int ves_icall_System_String_InternalIntern_raw (int,int);
int ves_icall_System_Type_internal_from_handle_raw (int,int);
int ves_icall_System_ValueType_InternalGetHashCode_raw (int,int,int);
int ves_icall_System_ValueType_Equals_raw (int,int,int,int);
int ves_icall_System_Threading_Interlocked_CompareExchange_Int (int,int,int);
void ves_icall_System_Threading_Interlocked_CompareExchange_Object (int,int,int,int);
int ves_icall_System_Threading_Interlocked_Decrement_Int (int);
int ves_icall_System_Threading_Interlocked_Increment_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Increment_Long (int);
int ves_icall_System_Threading_Interlocked_Exchange_Int (int,int);
void ves_icall_System_Threading_Interlocked_Exchange_Object (int,int,int);
int64_t ves_icall_System_Threading_Interlocked_CompareExchange_Long (int,int64_t,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Exchange_Long (int,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Read_Long (int);
int ves_icall_System_Threading_Interlocked_Add_Int (int,int);
int64_t ves_icall_System_Threading_Interlocked_Add_Long (int,int64_t);
void ves_icall_System_Threading_Monitor_Monitor_Enter_raw (int,int);
void mono_monitor_exit_icall_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_wait_raw (int,int,int,int);
void ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw (int,int,int,int,int);
void ves_icall_System_Threading_Thread_InitInternal_raw (int,int);
int ves_icall_System_Threading_Thread_GetCurrentThread ();
void ves_icall_System_Threading_InternalThread_Thread_free_internal_raw (int,int);
int ves_icall_System_Threading_Thread_GetState_raw (int,int);
void ves_icall_System_Threading_Thread_SetState_raw (int,int,int);
void ves_icall_System_Threading_Thread_ClrState_raw (int,int,int);
void ves_icall_System_Threading_Thread_SetName_icall_raw (int,int,int,int);
int ves_icall_System_Threading_Thread_YieldInternal ();
void ves_icall_System_Threading_Thread_SetPriority_raw (int,int,int);
void ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw (int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw (int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw (int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw (int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw (int,int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw (int);
int ves_icall_System_GCHandle_InternalAlloc_raw (int,int,int);
void ves_icall_System_GCHandle_InternalFree_raw (int,int);
int ves_icall_System_GCHandle_InternalGet_raw (int,int);
void ves_icall_System_GCHandle_InternalSet_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError ();
void ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError (int);
void ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw (int,int,int,int);
void ves_icall_System_Runtime_InteropServices_Marshal_PtrToStructureInternal_raw (int,int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_GetFunctionPointerForDelegateInternal_raw (int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw (int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalGetHashCode_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalTryGetHashCode_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw (int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw (int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetSpanDataFrom_raw (int,int,int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack ();
int ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw (int,int);
int ves_icall_System_Reflection_Assembly_GetCallingAssembly_raw (int);
int ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw (int);
int ves_icall_System_Reflection_Assembly_InternalLoad_raw (int,int,int,int);
int ves_icall_System_Reflection_Assembly_InternalGetType_raw (int,int,int,int,int,int);
int ves_icall_System_Reflection_AssemblyName_GetNativeName (int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw (int,int,int,int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw (int,int);
int ves_icall_MonoCustomAttrs_IsDefinedInternal_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw (int,int);
int ves_icall_System_Reflection_LoaderAllocatorScout_Destroy (int);
void ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw (int,int,int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw (int,int,int,int,int);
void ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw (int,int,int,int,int,int,int);
void ves_icall_RuntimeEventInfo_get_event_info_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_ResolveType_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetParentType_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_GetFieldOffset_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetValueInternal_raw (int,int,int);
void ves_icall_RuntimeFieldInfo_SetValueInternal_raw (int,int,int,int);
int ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
void ves_icall_get_method_info_raw (int,int,int);
int ves_icall_get_method_attributes (int);
int ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw (int,int,int);
int ves_icall_System_MonoMethodInfo_get_retval_marshal_raw (int,int);
int ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw (int,int,int,int);
int ves_icall_RuntimeMethodInfo_get_name_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_base_method_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
void ves_icall_RuntimeMethodInfo_GetPInvoke_raw (int,int,int,int,int);
int ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw (int,int,int);
int ves_icall_RuntimeMethodInfo_GetGenericArguments_raw (int,int);
int ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw (int,int);
void ves_icall_InvokeClassConstructor_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw (int,int);
void ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw (int,int,int);
int ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw (int,int,int,int,int,int);
int ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw (int,int,int,int,int,int);
void ves_icall_RuntimePropertyInfo_get_property_info_raw (int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_CustomAttributeBuilder_GetBlob_raw (int,int,int,int,int,int,int,int);
void ves_icall_DynamicMethod_create_dynamic_method_raw (int,int,int,int,int);
void ves_icall_AssemblyBuilder_basic_init_raw (int,int);
void ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw (int,int);
void ves_icall_ModuleBuilder_basic_init_raw (int,int);
void ves_icall_ModuleBuilder_set_wrappers_type_raw (int,int,int);
int ves_icall_ModuleBuilder_getUSIndex_raw (int,int,int);
int ves_icall_ModuleBuilder_getToken_raw (int,int,int,int);
int ves_icall_ModuleBuilder_getMethodToken_raw (int,int,int,int);
void ves_icall_ModuleBuilder_RegisterToken_raw (int,int,int,int);
int ves_icall_TypeBuilder_create_runtime_class_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw (int,int);
int ves_icall_System_Diagnostics_Debugger_IsAttached_internal ();
int ves_icall_System_Diagnostics_Debugger_IsLogging ();
void ves_icall_System_Diagnostics_Debugger_Log (int,int,int);
int ves_icall_System_Diagnostics_StackFrame_GetFrameInfo (int,int,int,int,int,int,int,int);
void ves_icall_System_Diagnostics_StackTrace_GetTrace (int,int,int,int);
int ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass (int);
void ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree (int);
int ves_icall_Mono_SafeStringMarshal_StringToUtf8 (int);
void ves_icall_Mono_SafeStringMarshal_GFree (int);
static void *corlib_icall_funcs [] = {
// token 177,
ves_icall_System_Array_InternalCreate,
// token 189,
ves_icall_System_Array_GetCorElementTypeOfElementTypeInternal,
// token 190,
ves_icall_System_Array_IsValueOfElementTypeInternal,
// token 191,
ves_icall_System_Array_CanChangePrimitive,
// token 192,
ves_icall_System_Array_FastCopy,
// token 193,
ves_icall_System_Array_GetLengthInternal_raw,
// token 194,
ves_icall_System_Array_GetLowerBoundInternal_raw,
// token 195,
ves_icall_System_Array_GetGenericValue_icall,
// token 196,
ves_icall_System_Array_GetValueImpl_raw,
// token 197,
ves_icall_System_Array_SetGenericValue_icall,
// token 200,
ves_icall_System_Array_SetValueImpl_raw,
// token 201,
ves_icall_System_Array_InitializeInternal_raw,
// token 202,
ves_icall_System_Array_SetValueRelaxedImpl_raw,
// token 375,
ves_icall_System_Runtime_RuntimeImports_ZeroMemory,
// token 376,
ves_icall_System_Runtime_RuntimeImports_Memmove,
// token 377,
ves_icall_System_Buffer_BulkMoveWithWriteBarrier,
// token 406,
ves_icall_System_Delegate_AllocDelegateLike_internal_raw,
// token 407,
ves_icall_System_Delegate_CreateDelegate_internal_raw,
// token 408,
ves_icall_System_Delegate_GetVirtualMethod_internal_raw,
// token 428,
ves_icall_System_Enum_GetEnumValuesAndNames_raw,
// token 429,
ves_icall_System_Enum_InternalBoxEnum_raw,
// token 430,
ves_icall_System_Enum_InternalGetCorElementType,
// token 431,
ves_icall_System_Enum_InternalGetUnderlyingType_raw,
// token 548,
ves_icall_System_Environment_get_ProcessorCount,
// token 549,
ves_icall_System_Environment_get_TickCount,
// token 550,
ves_icall_System_Environment_get_TickCount64,
// token 553,
ves_icall_System_Environment_FailFast_raw,
// token 595,
ves_icall_System_GC_GetCollectionCount,
// token 596,
ves_icall_System_GC_AddPressure,
// token 597,
ves_icall_System_GC_RemovePressure,
// token 598,
ves_icall_System_GC_register_ephemeron_array_raw,
// token 599,
ves_icall_System_GC_get_ephemeron_tombstone_raw,
// token 604,
ves_icall_System_GC_SuppressFinalize_raw,
// token 606,
ves_icall_System_GC_ReRegisterForFinalize_raw,
// token 608,
ves_icall_System_GC_GetGCMemoryInfo,
// token 610,
ves_icall_System_GC_AllocPinnedArray_raw,
// token 615,
ves_icall_System_Object_MemberwiseClone_raw,
// token 623,
ves_icall_System_Math_Acos,
// token 624,
ves_icall_System_Math_Acosh,
// token 625,
ves_icall_System_Math_Asin,
// token 626,
ves_icall_System_Math_Asinh,
// token 627,
ves_icall_System_Math_Atan,
// token 628,
ves_icall_System_Math_Atan2,
// token 629,
ves_icall_System_Math_Atanh,
// token 630,
ves_icall_System_Math_Cbrt,
// token 631,
ves_icall_System_Math_Ceiling,
// token 632,
ves_icall_System_Math_Cos,
// token 633,
ves_icall_System_Math_Cosh,
// token 634,
ves_icall_System_Math_Exp,
// token 635,
ves_icall_System_Math_Floor,
// token 636,
ves_icall_System_Math_Log,
// token 637,
ves_icall_System_Math_Log10,
// token 638,
ves_icall_System_Math_Pow,
// token 639,
ves_icall_System_Math_Sin,
// token 641,
ves_icall_System_Math_Sinh,
// token 642,
ves_icall_System_Math_Sqrt,
// token 643,
ves_icall_System_Math_Tan,
// token 644,
ves_icall_System_Math_Tanh,
// token 645,
ves_icall_System_Math_FusedMultiplyAdd,
// token 646,
ves_icall_System_Math_Log2,
// token 647,
ves_icall_System_Math_ModF,
// token 741,
ves_icall_System_MathF_Acos,
// token 742,
ves_icall_System_MathF_Acosh,
// token 743,
ves_icall_System_MathF_Asin,
// token 744,
ves_icall_System_MathF_Asinh,
// token 745,
ves_icall_System_MathF_Atan,
// token 746,
ves_icall_System_MathF_Atan2,
// token 747,
ves_icall_System_MathF_Atanh,
// token 748,
ves_icall_System_MathF_Cbrt,
// token 749,
ves_icall_System_MathF_Ceiling,
// token 750,
ves_icall_System_MathF_Cos,
// token 751,
ves_icall_System_MathF_Cosh,
// token 752,
ves_icall_System_MathF_Exp,
// token 753,
ves_icall_System_MathF_Floor,
// token 754,
ves_icall_System_MathF_Log,
// token 755,
ves_icall_System_MathF_Log10,
// token 756,
ves_icall_System_MathF_Pow,
// token 757,
ves_icall_System_MathF_Sin,
// token 759,
ves_icall_System_MathF_Sinh,
// token 760,
ves_icall_System_MathF_Sqrt,
// token 761,
ves_icall_System_MathF_Tan,
// token 762,
ves_icall_System_MathF_Tanh,
// token 763,
ves_icall_System_MathF_FusedMultiplyAdd,
// token 764,
ves_icall_System_MathF_Log2,
// token 765,
ves_icall_System_MathF_ModF,
// token 832,
ves_icall_RuntimeMethodHandle_ReboxFromNullable_raw,
// token 833,
ves_icall_RuntimeMethodHandle_ReboxToNullable_raw,
// token 901,
ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw,
// token 908,
ves_icall_RuntimeType_make_array_type_raw,
// token 911,
ves_icall_RuntimeType_make_byref_type_raw,
// token 913,
ves_icall_RuntimeType_make_pointer_type_raw,
// token 918,
ves_icall_RuntimeType_MakeGenericType_raw,
// token 919,
ves_icall_RuntimeType_GetMethodsByName_native_raw,
// token 921,
ves_icall_RuntimeType_GetPropertiesByName_native_raw,
// token 922,
ves_icall_RuntimeType_GetConstructors_native_raw,
// token 926,
ves_icall_System_RuntimeType_CreateInstanceInternal_raw,
// token 927,
ves_icall_System_RuntimeType_AllocateValueType_raw,
// token 929,
ves_icall_RuntimeType_GetDeclaringMethod_raw,
// token 931,
ves_icall_System_RuntimeType_getFullName_raw,
// token 932,
ves_icall_RuntimeType_GetGenericArgumentsInternal_raw,
// token 935,
ves_icall_RuntimeType_GetGenericParameterPosition,
// token 936,
ves_icall_RuntimeType_GetEvents_native_raw,
// token 937,
ves_icall_RuntimeType_GetFields_native_raw,
// token 940,
ves_icall_RuntimeType_GetInterfaces_raw,
// token 942,
ves_icall_RuntimeType_GetNestedTypes_native_raw,
// token 945,
ves_icall_RuntimeType_GetDeclaringType_raw,
// token 947,
ves_icall_RuntimeType_GetName_raw,
// token 949,
ves_icall_RuntimeType_GetNamespace_raw,
// token 958,
ves_icall_RuntimeType_FunctionPointerReturnAndParameterTypes_raw,
// token 1025,
ves_icall_RuntimeTypeHandle_GetAttributes,
// token 1027,
ves_icall_RuntimeTypeHandle_GetMetadataToken_raw,
// token 1029,
ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw,
// token 1039,
ves_icall_RuntimeTypeHandle_GetCorElementType,
// token 1040,
ves_icall_RuntimeTypeHandle_HasInstantiation,
// token 1041,
ves_icall_RuntimeTypeHandle_IsComObject_raw,
// token 1042,
ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw,
// token 1044,
ves_icall_RuntimeTypeHandle_HasReferences_raw,
// token 1051,
ves_icall_RuntimeTypeHandle_GetArrayRank_raw,
// token 1052,
ves_icall_RuntimeTypeHandle_GetAssembly_raw,
// token 1053,
ves_icall_RuntimeTypeHandle_GetElementType_raw,
// token 1054,
ves_icall_RuntimeTypeHandle_GetModule_raw,
// token 1055,
ves_icall_RuntimeTypeHandle_GetBaseType_raw,
// token 1063,
ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw,
// token 1064,
ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition,
// token 1065,
ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw,
// token 1069,
ves_icall_RuntimeTypeHandle_is_subclass_of_raw,
// token 1070,
ves_icall_RuntimeTypeHandle_IsByRefLike_raw,
// token 1072,
ves_icall_System_RuntimeTypeHandle_internal_from_name_raw,
// token 1076,
ves_icall_System_String_FastAllocateString_raw,
// token 1077,
ves_icall_System_String_InternalIsInterned_raw,
// token 1078,
ves_icall_System_String_InternalIntern_raw,
// token 1362,
ves_icall_System_Type_internal_from_handle_raw,
// token 1553,
ves_icall_System_ValueType_InternalGetHashCode_raw,
// token 1554,
ves_icall_System_ValueType_Equals_raw,
// token 9235,
ves_icall_System_Threading_Interlocked_CompareExchange_Int,
// token 9236,
ves_icall_System_Threading_Interlocked_CompareExchange_Object,
// token 9238,
ves_icall_System_Threading_Interlocked_Decrement_Int,
// token 9239,
ves_icall_System_Threading_Interlocked_Increment_Int,
// token 9240,
ves_icall_System_Threading_Interlocked_Increment_Long,
// token 9241,
ves_icall_System_Threading_Interlocked_Exchange_Int,
// token 9242,
ves_icall_System_Threading_Interlocked_Exchange_Object,
// token 9244,
ves_icall_System_Threading_Interlocked_CompareExchange_Long,
// token 9246,
ves_icall_System_Threading_Interlocked_Exchange_Long,
// token 9248,
ves_icall_System_Threading_Interlocked_Read_Long,
// token 9249,
ves_icall_System_Threading_Interlocked_Add_Int,
// token 9250,
ves_icall_System_Threading_Interlocked_Add_Long,
// token 9261,
ves_icall_System_Threading_Monitor_Monitor_Enter_raw,
// token 9263,
mono_monitor_exit_icall_raw,
// token 9268,
ves_icall_System_Threading_Monitor_Monitor_pulse_raw,
// token 9270,
ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw,
// token 9272,
ves_icall_System_Threading_Monitor_Monitor_wait_raw,
// token 9274,
ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw,
// token 9325,
ves_icall_System_Threading_Thread_InitInternal_raw,
// token 9326,
ves_icall_System_Threading_Thread_GetCurrentThread,
// token 9328,
ves_icall_System_Threading_InternalThread_Thread_free_internal_raw,
// token 9329,
ves_icall_System_Threading_Thread_GetState_raw,
// token 9330,
ves_icall_System_Threading_Thread_SetState_raw,
// token 9331,
ves_icall_System_Threading_Thread_ClrState_raw,
// token 9332,
ves_icall_System_Threading_Thread_SetName_icall_raw,
// token 9334,
ves_icall_System_Threading_Thread_YieldInternal,
// token 9336,
ves_icall_System_Threading_Thread_SetPriority_raw,
// token 10445,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw,
// token 10449,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw,
// token 10451,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw,
// token 10452,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw,
// token 10453,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw,
// token 10454,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw,
// token 10633,
ves_icall_System_GCHandle_InternalAlloc_raw,
// token 10634,
ves_icall_System_GCHandle_InternalFree_raw,
// token 10635,
ves_icall_System_GCHandle_InternalGet_raw,
// token 10636,
ves_icall_System_GCHandle_InternalSet_raw,
// token 10655,
ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError,
// token 10656,
ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError,
// token 10657,
ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw,
// token 10659,
ves_icall_System_Runtime_InteropServices_Marshal_PtrToStructureInternal_raw,
// token 10661,
ves_icall_System_Runtime_InteropServices_Marshal_GetFunctionPointerForDelegateInternal_raw,
// token 10662,
ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw,
// token 10793,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalGetHashCode_raw,
// token 10795,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalTryGetHashCode_raw,
// token 10797,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw,
// token 10807,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw,
// token 10808,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw,
// token 10809,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetSpanDataFrom_raw,
// token 10810,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw,
// token 10811,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack,
// token 11271,
ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw,
// token 11272,
ves_icall_System_Reflection_Assembly_GetCallingAssembly_raw,
// token 11273,
ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw,
// token 11278,
ves_icall_System_Reflection_Assembly_InternalLoad_raw,
// token 11279,
ves_icall_System_Reflection_Assembly_InternalGetType_raw,
// token 11314,
ves_icall_System_Reflection_AssemblyName_GetNativeName,
// token 11334,
ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw,
// token 11341,
ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw,
// token 11348,
ves_icall_MonoCustomAttrs_IsDefinedInternal_raw,
// token 11359,
ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw,
// token 11363,
ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw,
// token 11388,
ves_icall_System_Reflection_LoaderAllocatorScout_Destroy,
// token 11468,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw,
// token 11470,
ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw,
// token 11481,
ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw,
// token 11483,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw,
// token 11484,
ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw,
// token 11485,
ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw,
// token 11492,
ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw,
// token 11506,
ves_icall_RuntimeEventInfo_get_event_info_raw,
// token 11526,
ves_icall_reflection_get_token_raw,
// token 11527,
ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw,
// token 11535,
ves_icall_RuntimeFieldInfo_ResolveType_raw,
// token 11537,
ves_icall_RuntimeFieldInfo_GetParentType_raw,
// token 11544,
ves_icall_RuntimeFieldInfo_GetFieldOffset_raw,
// token 11545,
ves_icall_RuntimeFieldInfo_GetValueInternal_raw,
// token 11548,
ves_icall_RuntimeFieldInfo_SetValueInternal_raw,
// token 11550,
ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw,
// token 11555,
ves_icall_reflection_get_token_raw,
// token 11561,
ves_icall_get_method_info_raw,
// token 11562,
ves_icall_get_method_attributes,
// token 11569,
ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw,
// token 11571,
ves_icall_System_MonoMethodInfo_get_retval_marshal_raw,
// token 11583,
ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw,
// token 11586,
ves_icall_RuntimeMethodInfo_get_name_raw,
// token 11587,
ves_icall_RuntimeMethodInfo_get_base_method_raw,
// token 11588,
ves_icall_reflection_get_token_raw,
// token 11599,
ves_icall_InternalInvoke_raw,
// token 11608,
ves_icall_RuntimeMethodInfo_GetPInvoke_raw,
// token 11614,
ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw,
// token 11615,
ves_icall_RuntimeMethodInfo_GetGenericArguments_raw,
// token 11616,
ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw,
// token 11618,
ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw,
// token 11619,
ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw,
// token 11636,
ves_icall_InvokeClassConstructor_raw,
// token 11638,
ves_icall_InternalInvoke_raw,
// token 11652,
ves_icall_reflection_get_token_raw,
// token 11674,
ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw,
// token 11675,
ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw,
// token 11676,
ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw,
// token 11701,
ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw,
// token 11706,
ves_icall_RuntimePropertyInfo_get_property_info_raw,
// token 11736,
ves_icall_reflection_get_token_raw,
// token 11737,
ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw,
// token 12291,
ves_icall_CustomAttributeBuilder_GetBlob_raw,
// token 12305,
ves_icall_DynamicMethod_create_dynamic_method_raw,
// token 12400,
ves_icall_AssemblyBuilder_basic_init_raw,
// token 12401,
ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw,
// token 12616,
ves_icall_ModuleBuilder_basic_init_raw,
// token 12617,
ves_icall_ModuleBuilder_set_wrappers_type_raw,
// token 12625,
ves_icall_ModuleBuilder_getUSIndex_raw,
// token 12626,
ves_icall_ModuleBuilder_getToken_raw,
// token 12627,
ves_icall_ModuleBuilder_getMethodToken_raw,
// token 12633,
ves_icall_ModuleBuilder_RegisterToken_raw,
// token 12732,
ves_icall_TypeBuilder_create_runtime_class_raw,
// token 13312,
ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw,
// token 13313,
ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw,
// token 13885,
ves_icall_System_Diagnostics_Debugger_IsAttached_internal,
// token 13886,
ves_icall_System_Diagnostics_Debugger_IsLogging,
// token 13887,
ves_icall_System_Diagnostics_Debugger_Log,
// token 13892,
ves_icall_System_Diagnostics_StackFrame_GetFrameInfo,
// token 13902,
ves_icall_System_Diagnostics_StackTrace_GetTrace,
// token 14855,
ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass,
// token 14876,
ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree,
// token 14878,
ves_icall_Mono_SafeStringMarshal_StringToUtf8,
// token 14880,
ves_icall_Mono_SafeStringMarshal_GFree,
};
static uint8_t corlib_icall_flags [] = {
0,
0,
0,
0,
0,
4,
4,
0,
4,
0,
4,
4,
4,
0,
0,
0,
4,
4,
4,
4,
4,
0,
4,
0,
0,
0,
4,
0,
0,
0,
4,
4,
4,
4,
0,
4,
4,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
0,
0,
0,
0,
0,
0,
0,
};
