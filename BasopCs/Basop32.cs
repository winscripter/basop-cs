#define WMOPS
#define ENH_64_BIT_OPERATOR
#define ENH_U_32_BIT_OPERATOR

using Flag = byte;
using Word16 = short;
using Word32 = int;
using Word40 = long;
using Word64 = long;
using UWord16 = ushort;
using UWord32 = uint;
using UWord64 = ulong;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
#pragma warning disable IDE0047 // Remove unnecessary parentheses

namespace BasopCs;

/// <summary>
/// Represents an exception with the implementation of the basic operators.
/// </summary>
public class BasopRuntimeException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BasopRuntimeException"/> class.
    /// </summary>
    public BasopRuntimeException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BasopRuntimeException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public BasopRuntimeException(string? message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BasopRuntimeException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    public BasopRuntimeException(string? message, BasopRuntimeException? innerException) : base(message, innerException)
    {
    }
}

public struct cmplx(Word32 re, Word32 im)
{
    public Word32 re = re;
    public Word32 im = im;
}

public struct cmplx_s(Word16 re, Word16 im)
{
    public Word16 re = re;
    public Word16 im = im;
}

// I actually generated this struct using a dumb Python script xD
/// <summary>
/// Stores operation counters used to calculate the complexity weight of codec operations.
/// </summary>
public struct BASIC_OP
{
    /// <summary>
    /// Counter for <see cref="add"/> operations. Complexity weight: 1.
    /// </summary>
    public uint add;

    /// <summary>
    /// Counter for <see cref="sub"/> operations. Complexity weight: 1.
    /// </summary>
    public uint sub;

    /// <summary>
    /// Counter for <see cref="abs_s"/> operations. Complexity weight: 1.
    /// </summary>
    public uint abs_s;

    /// <summary>
    /// Counter for <see cref="shl"/> operations. Complexity weight: 1.
    /// </summary>
    public uint shl;

    /// <summary>
    /// Counter for <see cref="shr"/> operations. Complexity weight: 1.
    /// </summary>
    public uint shr;

    /// <summary>
    /// Counter for <see cref="extract_h"/> operations. Complexity weight: 1.
    /// </summary>
    public uint extract_h;

    /// <summary>
    /// Counter for <see cref="extract_l"/> operations. Complexity weight: 1.
    /// </summary>
    public uint extract_l;

    /// <summary>
    /// Counter for <see cref="mult"/> operations. Complexity weight: 1.
    /// </summary>
    public uint mult;

    /// <summary>
    /// Counter for <see cref="L_mult"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_mult;

    /// <summary>
    /// Counter for <see cref="negate"/> operations. Complexity weight: 1.
    /// </summary>
    public uint negate;

    /// <summary>
    /// Counter for <see cref="round"/> operations. Complexity weight: 1.
    /// </summary>
    public uint round;

    /// <summary>
    /// Counter for <see cref="L_mac"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_mac;

    /// <summary>
    /// Counter for <see cref="L_msu"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_msu;

    /// <summary>
    /// Counter for <see cref="L_macNs"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_macNs;

    /// <summary>
    /// Counter for <see cref="L_msuNs"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_msuNs;

    /// <summary>
    /// Counter for <see cref="L_add"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_add;

    /// <summary>
    /// Counter for <see cref="L_sub"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_sub;

    /// <summary>
    /// Counter for <see cref="L_add_c"/> operations. Complexity weight: 2.
    /// </summary>
    public uint L_add_c;

    /// <summary>
    /// Counter for <see cref="L_sub_c"/> operations. Complexity weight: 2.
    /// </summary>
    public uint L_sub_c;

    /// <summary>
    /// Counter for <see cref="L_negate"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_negate;

    /// <summary>
    /// Counter for <see cref="L_shl"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_shl;

    /// <summary>
    /// Counter for <see cref="L_shr"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_shr;

    /// <summary>
    /// Counter for <see cref="mult_r"/> operations. Complexity weight: 1.
    /// </summary>
    public uint mult_r;

    /// <summary>
    /// Counter for <see cref="shr_r"/> operations. Complexity weight: 3.
    /// </summary>
    public uint shr_r;

    /// <summary>
    /// Counter for <see cref="mac_r"/> operations. Complexity weight: 1.
    /// </summary>
    public uint mac_r;

    /// <summary>
    /// Counter for <see cref="msu_r"/> operations. Complexity weight: 1.
    /// </summary>
    public uint msu_r;

    /// <summary>
    /// Counter for <see cref="L_deposit_h"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_deposit_h;

    /// <summary>
    /// Counter for <see cref="L_deposit_l"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_deposit_l;

    /// <summary>
    /// Counter for <see cref="L_shr_r"/> operations. Complexity weight: 3.
    /// </summary>
    public uint L_shr_r;

    /// <summary>
    /// Counter for <see cref="L_abs"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_abs;

    /// <summary>
    /// Counter for <see cref="L_sat"/> operations. Complexity weight: 4.
    /// </summary>
    public uint L_sat;

    /// <summary>
    /// Counter for <see cref="norm_s"/> operations. Complexity weight: 1.
    /// </summary>
    public uint norm_s;

    /// <summary>
    /// Counter for <see cref="div_s"/> operations. Complexity weight: 18.
    /// </summary>
    public uint div_s;

    /// <summary>
    /// Counter for <see cref="norm_l"/> operations. Complexity weight: 1.
    /// </summary>
    public uint norm_l;

    /// <summary>
    /// Counter for <see cref="move16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint move16;

    /// <summary>
    /// Counter for <see cref="move32"/> operations. Complexity weight: 2.
    /// </summary>
    public uint move32;

    /// <summary>
    /// Counter for <see cref="Logic16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint Logic16;

    /// <summary>
    /// Counter for <see cref="Logic32"/> operations. Complexity weight: 2.
    /// </summary>
    public uint Logic32;

    /// <summary>
    /// Counter for <see cref="Test"/> operations. Complexity weight: 2.
    /// </summary>
    public uint Test;

    /// <summary>
    /// Counter for <see cref="s_max"/> operations. Complexity weight: 1.
    /// </summary>
    public uint s_max;

    /// <summary>
    /// Counter for <see cref="s_min"/> operations. Complexity weight: 1.
    /// </summary>
    public uint s_min;

    /// <summary>
    /// Counter for <see cref="L_max"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_max;

    /// <summary>
    /// Counter for <see cref="L_min"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_min;

    /// <summary>
    /// Counter for <see cref="L40_max"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L40_max;

    /// <summary>
    /// Counter for <see cref="L40_min"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L40_min;

    /// <summary>
    /// Counter for <see cref="shl_r"/> operations. Complexity weight: 2.
    /// </summary>
    public uint shl_r;

    /// <summary>
    /// Counter for <see cref="L_shl_r"/> operations. Complexity weight: 2.
    /// </summary>
    public uint L_shl_r;

    /// <summary>
    /// Counter for <see cref="L40_shr_r"/> operations. Complexity weight: 2.
    /// </summary>
    public uint L40_shr_r;

    /// <summary>
    /// Counter for <see cref="L40_shl_r"/> operations. Complexity weight: 2.
    /// </summary>
    public uint L40_shl_r;

    /// <summary>
    /// Counter for <see cref="norm_L40"/> operations. Complexity weight: 1.
    /// </summary>
    public uint norm_L40;

    /// <summary>
    /// Counter for <see cref="L40_shl"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L40_shl;

    /// <summary>
    /// Counter for <see cref="L40_shr"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L40_shr;

    /// <summary>
    /// Counter for <see cref="L40_negate"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L40_negate;

    /// <summary>
    /// Counter for <see cref="L40_add"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L40_add;

    /// <summary>
    /// Counter for <see cref="L40_sub"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L40_sub;

    /// <summary>
    /// Counter for <see cref="L40_abs"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L40_abs;

    /// <summary>
    /// Counter for <see cref="L40_mult"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L40_mult;

    /// <summary>
    /// Counter for <see cref="L40_mac"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L40_mac;

    /// <summary>
    /// Counter for <see cref="mac_r40"/> operations. Complexity weight: 2.
    /// </summary>
    public uint mac_r40;

    /// <summary>
    /// Counter for <see cref="L40_msu"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L40_msu;

    /// <summary>
    /// Counter for <see cref="msu_r40"/> operations. Complexity weight: 2.
    /// </summary>
    public uint msu_r40;

    /// <summary>
    /// Counter for <see cref="Mpy_32_16_ss"/> operations. Complexity weight: 2.
    /// </summary>
    public uint Mpy_32_16_ss;

    /// <summary>
    /// Counter for <see cref="Mpy_32_32_ss"/> operations. Complexity weight: 2.
    /// </summary>
    public uint Mpy_32_32_ss;

    /// <summary>
    /// Counter for <see cref="L_mult0"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_mult0;

    /// <summary>
    /// Counter for <see cref="L_mac0"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_mac0;

    /// <summary>
    /// Counter for <see cref="L_msu0"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_msu0;

    /// <summary>
    /// Counter for <see cref="lshl"/> operations. Complexity weight: 1.
    /// </summary>
    public uint lshl;

    /// <summary>
    /// Counter for <see cref="lshr"/> operations. Complexity weight: 1.
    /// </summary>
    public uint lshr;

    /// <summary>
    /// Counter for <see cref="L_lshl"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_lshl;

    /// <summary>
    /// Counter for <see cref="L_lshr"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_lshr;

    /// <summary>
    /// Counter for <see cref="L40_lshl"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L40_lshl;

    /// <summary>
    /// Counter for <see cref="L40_lshr"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L40_lshr;

    /// <summary>
    /// Counter for <see cref="s_and"/> operations. Complexity weight: 1.
    /// </summary>
    public uint s_and;

    /// <summary>
    /// Counter for <see cref="s_or"/> operations. Complexity weight: 1.
    /// </summary>
    public uint s_or;

    /// <summary>
    /// Counter for <see cref="s_xor"/> operations. Complexity weight: 1.
    /// </summary>
    public uint s_xor;

    /// <summary>
    /// Counter for <see cref="L_and"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_and;

    /// <summary>
    /// Counter for <see cref="L_or"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_or;

    /// <summary>
    /// Counter for <see cref="L_xor"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_xor;

    /// <summary>
    /// Counter for <see cref="rotl"/> operations. Complexity weight: 3.
    /// </summary>
    public uint rotl;

    /// <summary>
    /// Counter for <see cref="rotr"/> operations. Complexity weight: 3.
    /// </summary>
    public uint rotr;

    /// <summary>
    /// Counter for <see cref="L_rotl"/> operations. Complexity weight: 3.
    /// </summary>
    public uint L_rotl;

    /// <summary>
    /// Counter for <see cref="L_rotr"/> operations. Complexity weight: 3.
    /// </summary>
    public uint L_rotr;

    /// <summary>
    /// Counter for <see cref="L40_set"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L40_set;

    /// <summary>
    /// Counter for <see cref="L40_deposit_h"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L40_deposit_h;

    /// <summary>
    /// Counter for <see cref="L40_deposit_l"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L40_deposit_l;

    /// <summary>
    /// Counter for <see cref="L40_deposit32"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L40_deposit32;

    /// <summary>
    /// Counter for <see cref="Extract40_H"/> operations. Complexity weight: 1.
    /// </summary>
    public uint Extract40_H;

    /// <summary>
    /// Counter for <see cref="Extract40_L"/> operations. Complexity weight: 1.
    /// </summary>
    public uint Extract40_L;

    /// <summary>
    /// Counter for <see cref="L_Extract40"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_Extract40;

    /// <summary>
    /// Counter for <see cref="L40_round"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L40_round;

    /// <summary>
    /// Counter for <see cref="L_saturate40"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_saturate40;

    /// <summary>
    /// Counter for <see cref="round40"/> operations. Complexity weight: 1.
    /// </summary>
    public uint round40;

    /// <summary>
    /// Counter for <see cref="If"/> operations. Complexity weight: 3.
    /// </summary>
    public uint If;

    /// <summary>
    /// Counter for <see cref="Goto"/> operations. Complexity weight: 2.
    /// </summary>
    public uint Goto;

    /// <summary>
    /// Counter for <see cref="Break"/> operations. Complexity weight: 2.
    /// </summary>
    public uint Break;

    /// <summary>
    /// Counter for <see cref="Switch"/> operations. Complexity weight: 6.
    /// </summary>
    public uint Switch;

    /// <summary>
    /// Counter for <see cref="For"/> operations. Complexity weight: 3.
    /// </summary>
    public uint For;

    /// <summary>
    /// Counter for <see cref="While"/> operations. Complexity weight: 3.
    /// </summary>
    public uint While;

    /// <summary>
    /// Counter for <see cref="Continue"/> operations. Complexity weight: 2.
    /// </summary>
    public uint Continue;

    /// <summary>
    /// Counter for <see cref="L_mls"/> operations. Complexity weight: 1.
    /// </summary>
    public uint L_mls;

    /// <summary>
    /// Counter for <see cref="div_l"/> operations. Complexity weight: 32.
    /// </summary>
    public uint div_l;

    /// <summary>
    /// Counter for <see cref="i_mult"/> operations. Complexity weight: 1.
    /// </summary>
    public uint i_mult;

    /// <summary>
    /// Counter for <see cref="CL_shr"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_shr;

    /// <summary>
    /// Counter for <see cref="CL_shl"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_shl;

    /// <summary>
    /// Counter for <see cref="CL_add"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_add;

    /// <summary>
    /// Counter for <see cref="CL_sub"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_sub;

    /// <summary>
    /// Counter for <see cref="CL_scale"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_scale;

    /// <summary>
    /// Counter for <see cref="CL_dscale"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_dscale;

    /// <summary>
    /// Counter for <see cref="CL_msu_j"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_msu_j;

    /// <summary>
    /// Counter for <see cref="CL_mac_j"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_mac_j;

    /// <summary>
    /// Counter for <see cref="CL_move"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_move;

    /// <summary>
    /// Counter for <see cref="CL_Extract_real"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_Extract_real;

    /// <summary>
    /// Counter for <see cref="CL_Extract_imag"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_Extract_imag;

    /// <summary>
    /// Counter for <see cref="CL_form"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_form;

    /// <summary>
    /// Counter for <see cref="CL_multr_32x16"/> operations. Complexity weight: 2.
    /// </summary>
    public uint CL_multr_32x16;

    /// <summary>
    /// Counter for <see cref="CL_negate"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_negate;

    /// <summary>
    /// Counter for <see cref="CL_conjugate"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_conjugate;

    /// <summary>
    /// Counter for <see cref="CL_mul_j"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_mul_j;

    /// <summary>
    /// Counter for <see cref="CL_swap_real_imag"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_swap_real_imag;

    /// <summary>
    /// Counter for <see cref="C_add"/> operations. Complexity weight: 1.
    /// </summary>
    public uint C_add;

    /// <summary>
    /// Counter for <see cref="C_sub"/> operations. Complexity weight: 1.
    /// </summary>
    public uint C_sub;

    /// <summary>
    /// Counter for <see cref="C_mul_j"/> operations. Complexity weight: 1.
    /// </summary>
    public uint C_mul_j;

    /// <summary>
    /// Counter for <see cref="C_multr"/> operations. Complexity weight: 2.
    /// </summary>
    public uint C_multr;

    /// <summary>
    /// Counter for <see cref="C_form"/> operations. Complexity weight: 1.
    /// </summary>
    public uint C_form;

    /// <summary>
    /// Counter for <see cref="C_scale"/> operations. Complexity weight: 1.
    /// </summary>
    public uint C_scale;

    /// <summary>
    /// Counter for <see cref="CL_round32_16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_round32_16;

    /// <summary>
    /// Counter for <see cref="CL_scale_32"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_scale_32;

    /// <summary>
    /// Counter for <see cref="CL_dscale_32"/> operations. Complexity weight: 1.
    /// </summary>
    public uint CL_dscale_32;

    /// <summary>
    /// Counter for <see cref="CL_multr_32x32"/> operations. Complexity weight: 2.
    /// </summary>
    public uint CL_multr_32x32;

    /// <summary>
    /// Counter for <see cref="C_mac_r"/> operations. Complexity weight: 2.
    /// </summary>
    public uint C_mac_r;

    /// <summary>
    /// Counter for <see cref="C_msu_r"/> operations. Complexity weight: 2.
    /// </summary>
    public uint C_msu_r;

    /// <summary>
    /// Counter for <see cref="C_Extract_real"/> operations. Complexity weight: 1.
    /// </summary>
    public uint C_Extract_real;

    /// <summary>
    /// Counter for <see cref="C_Extract_imag"/> operations. Complexity weight: 1.
    /// </summary>
    public uint C_Extract_imag;

    /// <summary>
    /// Counter for <see cref="C_negate"/> operations. Complexity weight: 1.
    /// </summary>
    public uint C_negate;

    /// <summary>
    /// Counter for <see cref="C_conjugate"/> operations. Complexity weight: 1.
    /// </summary>
    public uint C_conjugate;

    /// <summary>
    /// Counter for <see cref="C_shr"/> operations. Complexity weight: 1.
    /// </summary>
    public uint C_shr;

    /// <summary>
    /// Counter for <see cref="C_shl"/> operations. Complexity weight: 1.
    /// </summary>
    public uint C_shl;

    /// <summary>
    /// Counter for <see cref="move64"/> operations. Complexity weight: 1.
    /// </summary>
    public uint move64;

    /// <summary>
    /// Counter for <see cref="W_add_nosat"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_add_nosat;

    /// <summary>
    /// Counter for <see cref="W_sub_nosat"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_sub_nosat;

    /// <summary>
    /// Counter for <see cref="W_shl"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_shl;

    /// <summary>
    /// Counter for <see cref="W_shr"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_shr;

    /// <summary>
    /// Counter for <see cref="W_shl_nosat"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_shl_nosat;

    /// <summary>
    /// Counter for <see cref="W_shr_nosat"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_shr_nosat;

    /// <summary>
    /// Counter for <see cref="W_mac_32_16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_mac_32_16;

    /// <summary>
    /// Counter for <see cref="W_msu_32_16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_msu_32_16;

    /// <summary>
    /// Counter for <see cref="W_mult_32_16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_mult_32_16;

    /// <summary>
    /// Counter for <see cref="W_mult0_16_16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_mult0_16_16;

    /// <summary>
    /// Counter for <see cref="W_mac0_16_16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_mac0_16_16;

    /// <summary>
    /// Counter for <see cref="W_msu0_16_16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_msu0_16_16;

    /// <summary>
    /// Counter for <see cref="W_mult_16_16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_mult_16_16;

    /// <summary>
    /// Counter for <see cref="W_mac_16_16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_mac_16_16;

    /// <summary>
    /// Counter for <see cref="W_msu_16_16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_msu_16_16;

    /// <summary>
    /// Counter for <see cref="W_shl_sat_l"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_shl_sat_l;

    /// <summary>
    /// Counter for <see cref="W_sat_l"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_sat_l;

    /// <summary>
    /// Counter for <see cref="W_sat_m"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_sat_m;

    /// <summary>
    /// Counter for <see cref="W_deposit32_l"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_deposit32_l;

    /// <summary>
    /// Counter for <see cref="W_deposit32_h"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_deposit32_h;

    /// <summary>
    /// Counter for <see cref="W_extract_l"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_extract_l;

    /// <summary>
    /// Counter for <see cref="W_extract_h"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_extract_h;

    /// <summary>
    /// Counter for <see cref="W_round48_L"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_round48_L;

    /// <summary>
    /// Counter for <see cref="W_round32_s"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_round32_s;

    /// <summary>
    /// Counter for <see cref="W_norm"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_norm;

    /// <summary>
    /// Counter for <see cref="W_add"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_add;

    /// <summary>
    /// Counter for <see cref="W_sub"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_sub;

    /// <summary>
    /// Counter for <see cref="W_neg"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_neg;

    /// <summary>
    /// Counter for <see cref="W_abs"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_abs;

    /// <summary>
    /// Counter for <see cref="W_mult_32_32"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_mult_32_32;

    /// <summary>
    /// Counter for <see cref="W_mult0_32_32"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_mult0_32_32;

    /// <summary>
    /// Counter for <see cref="W_lshl"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_lshl;

    /// <summary>
    /// Counter for <see cref="W_lshr"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_lshr;

    /// <summary>
    /// Counter for <see cref="W_round64_L"/> operations. Complexity weight: 1.
    /// </summary>
    public uint W_round64_L;

    /// <summary>
    /// Counter for <see cref="Mpy_32_16_1"/> operations. Complexity weight: 1.
    /// </summary>
    public uint Mpy_32_16_1;

    /// <summary>
    /// Counter for <see cref="Mpy_32_16_r"/> operations. Complexity weight: 1.
    /// </summary>
    public uint Mpy_32_16_r;

    /// <summary>
    /// Counter for <see cref="Mpy_32_32"/> operations. Complexity weight: 1.
    /// </summary>
    public uint Mpy_32_32;

    /// <summary>
    /// Counter for <see cref="Mpy_32_32_r"/> operations. Complexity weight: 1.
    /// </summary>
    public uint Mpy_32_32_r;

    /// <summary>
    /// Counter for <see cref="Madd_32_16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint Madd_32_16;

    /// <summary>
    /// Counter for <see cref="Madd_32_16_r"/> operations. Complexity weight: 1.
    /// </summary>
    public uint Madd_32_16_r;

    /// <summary>
    /// Counter for <see cref="Msub_32_16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint Msub_32_16;

    /// <summary>
    /// Counter for <see cref="Msub_32_16_r"/> operations. Complexity weight: 1.
    /// </summary>
    public uint Msub_32_16_r;

    /// <summary>
    /// Counter for <see cref="Madd_32_32"/> operations. Complexity weight: 1.
    /// </summary>
    public uint Madd_32_32;

    /// <summary>
    /// Counter for <see cref="Madd_32_32_r"/> operations. Complexity weight: 1.
    /// </summary>
    public uint Madd_32_32_r;

    /// <summary>
    /// Counter for <see cref="Msub_32_32"/> operations. Complexity weight: 1.
    /// </summary>
    public uint Msub_32_32;

    /// <summary>
    /// Counter for <see cref="Msub_32_32_r"/> operations. Complexity weight: 1.
    /// </summary>
    public uint Msub_32_32_r;

    /// <summary>
    /// Counter for <see cref="UL_addNs"/> operations. Complexity weight: 1.
    /// </summary>
    public uint UL_addNs;

    /// <summary>
    /// Counter for <see cref="UL_subNs"/> operations. Complexity weight: 1.
    /// </summary>
    public uint UL_subNs;

    /// <summary>
    /// Counter for <see cref="UL_Mpy_32_32"/> operations. Complexity weight: 1.
    /// </summary>
    public uint UL_Mpy_32_32;

    /// <summary>
    /// Counter for <see cref="Mpy_32_32_uu"/> operations. Complexity weight: 2.
    /// </summary>
    public uint Mpy_32_32_uu;

    /// <summary>
    /// Counter for <see cref="Mpy_32_16_uu"/> operations. Complexity weight: 2.
    /// </summary>
    public uint Mpy_32_16_uu;

    /// <summary>
    /// Counter for <see cref="norm_ul"/> operations. Complexity weight: 1.
    /// </summary>
    public uint norm_ul;

    /// <summary>
    /// Counter for <see cref="UL_deposit_l"/> operations. Complexity weight: 1.
    /// </summary>
    public uint UL_deposit_l;

    /// <summary>
    /// Counter for <see cref="LT_16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint LT_16;

    /// <summary>
    /// Counter for <see cref="GT_16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint GT_16;

    /// <summary>
    /// Counter for <see cref="LE_16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint LE_16;

    /// <summary>
    /// Counter for <see cref="GE_16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint GE_16;

    /// <summary>
    /// Counter for <see cref="EQ_16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint EQ_16;

    /// <summary>
    /// Counter for <see cref="NE_16"/> operations. Complexity weight: 1.
    /// </summary>
    public uint NE_16;

    /// <summary>
    /// Counter for <see cref="LT_32"/> operations. Complexity weight: 1.
    /// </summary>
    public uint LT_32;

    /// <summary>
    /// Counter for <see cref="GT_32"/> operations. Complexity weight: 1.
    /// </summary>
    public uint GT_32;

    /// <summary>
    /// Counter for <see cref="LE_32"/> operations. Complexity weight: 1.
    /// </summary>
    public uint LE_32;

    /// <summary>
    /// Counter for <see cref="GE_32"/> operations. Complexity weight: 1.
    /// </summary>
    public uint GE_32;

    /// <summary>
    /// Counter for <see cref="EQ_32"/> operations. Complexity weight: 1.
    /// </summary>
    public uint EQ_32;

    /// <summary>
    /// Counter for <see cref="NE_32"/> operations. Complexity weight: 1.
    /// </summary>
    public uint NE_32;

    /// <summary>
    /// Counter for <see cref="LT_64"/> operations. Complexity weight: 1.
    /// </summary>
    public uint LT_64;

    /// <summary>
    /// Counter for <see cref="GT_64"/> operations. Complexity weight: 1.
    /// </summary>
    public uint GT_64;

    /// <summary>
    /// Counter for <see cref="LE_64"/> operations. Complexity weight: 1.
    /// </summary>
    public uint LE_64;

    /// <summary>
    /// Counter for <see cref="GE_64"/> operations. Complexity weight: 1.
    /// </summary>
    public uint GE_64;

    /// <summary>
    /// Counter for <see cref="EQ_64"/> operations. Complexity weight: 1.
    /// </summary>
    public uint EQ_64;

    /// <summary>
    /// Counter for <see cref="NE_64"/> operations. Complexity weight: 1.
    /// </summary>
    public uint NE_64;
}

/// <summary>
/// .NET port of ITU-T Basic Operators G.191/User's Group on
/// Software Tools (UGST) V2.3 (11/30/2009).
/// </summary>
public static unsafe class Basop32
{
    public const Word64 MAX_64 = (Word64)0x7fffffffffffffffL;

    public const Word64 MIN_64 = unchecked((Word64)0x8000000000000000L);

    /// <summary>
    /// <see cref="int.MaxValue"/>
    /// </summary>
    public const int MAX_32 = 0x7fffffff;

    /// <summary>
    /// <see cref="int.MinValue"/>
    /// </summary>
    public const int MIN_32 = unchecked((int)0x80000000);

    /// <summary>
    /// <see cref="short.MaxValue"/>
    /// </summary>
    public const short MAX_16 = 0x7fff;

    /// <summary>
    /// <see cref="short.MinValue"/>
    /// </summary>
    public const short MIN_16 = unchecked((short)0x8000);

    /// <summary>
    /// Whether memory-write operations are recorded.
    /// </summary>
    public const bool WMOPS = true;

    /// <summary>
    /// Maximum write counters.
    /// </summary>
    public const int MAXCOUNTERS = 256;

    public const Word40 MAX_40 = 0x0000007fffffffff;

    public const Word40 MIN_40 = unchecked((Word40)0xffffff8000000000);

    public static readonly BASIC_OP[] multiCounter = new BASIC_OP[MAXCOUNTERS];

    public static int currCounter;

    /*___________________________________________________________________________
     |                                                                           |
     |   Constants and Globals                                                   |
     |___________________________________________________________________________|
    */

    public static Flag Overflow;
    public static Flag Carry;

    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : saturate                                                |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |    Limit the 32 bit input to the range of a 16 bit word. Must NOT be      |
     |    referenced from outside applications.                                  |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var1                                                                 |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var1 <= 0x7fff ffff.                 |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    var_out                                                                |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var_out <= 0x0000 7fff.                |
     |___________________________________________________________________________|
    */
    public static Word16 saturate(Word32 L_var1)
    {
        unchecked
        {
            Word16 var_out;

            if (L_var1 > 0X00007fffL)
            {
                Overflow = 1;
                var_out = MAX_16;
            }
            else if (L_var1 < (Word32)0xffff8000L)
            {
                Overflow = 1;
                var_out = MIN_16;
            }
            else
            {
                var_out = extract_l(L_var1);
#if (WMOPS)
    multiCounter[currCounter].extract_l--;
#endif
            }

            return (var_out);
        }
    }

    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : add                                                     |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |    Performs the addition (var1+var2) with overflow control and saturation;|
     |    the 16 bit result is set at +32767 when overflow occurs or at -32768   |
     |    when underflow occurs.                                                 |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    var1                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |    var2                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    var_out                                                                |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var_out <= 0x0000 7fff.                |
     |___________________________________________________________________________|
    */
    public static Word16 add(Word16 var1, Word16 var2)
    {
        Word16 var_out;
        Word32 L_sum;

        L_sum = (Word32)var1 + var2;
        var_out = saturate(L_sum);

#if (WMOPS)
        multiCounter[currCounter].add++;
#endif
        return (var_out);
    }

    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : sub                                                     |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |    Performs the subtraction (var1+var2) with overflow control and satu-   |
     |    ration; the 16 bit result is set at +32767 when overflow occurs or at  |
     |    -32768 when underflow occurs.                                          |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    var1                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |    var2                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    var_out                                                                |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var_out <= 0x0000 7fff.                |
     |___________________________________________________________________________|
    */
    public static Word16 sub(Word16 var1, Word16 var2)
    {
        Word16 var_out;
        Word32 L_diff;

        L_diff = (Word32)var1 - var2;
        var_out = saturate(L_diff);

#if (WMOPS)
        multiCounter[currCounter].sub++;
#endif
        return (var_out);
    }

    /*___________________________________________________________________________
 |                                                                           |
 |   Function Name : abs_s                                                   |
 |                                                                           |
 |   Purpose :                                                               |
 |                                                                           |
 |    Absolute value of var1; abs_s(-32768) = 32767.                         |
 |                                                                           |
 |   Complexity weight : 1                                                   |
 |                                                                           |
 |   Inputs :                                                                |
 |                                                                           |
 |    var1                                                                   |
 |             16 bit short signed integer (Word16) whose value falls in the |
 |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
 |                                                                           |
 |   Outputs :                                                               |
 |                                                                           |
 |    none                                                                   |
 |                                                                           |
 |   Return Value :                                                          |
 |                                                                           |
 |    var_out                                                                |
 |             16 bit short signed integer (Word16) whose value falls in the |
 |             range : 0x0000 0000 <= var_out <= 0x0000 7fff.                |
 |___________________________________________________________________________|
*/
    public static Word16 abs_s(Word16 var1)
    {
        Word16 var_out;

        if (var1 == (Word16)MIN_16)
        {
            var_out = MAX_16;
        }
        else
        {
            if (var1 < 0)
            {
                var_out = (Word16)(-var1);
            }
            else
            {
                var_out = var1;
            }
        }

#if (WMOPS)
        multiCounter[currCounter].abs_s++;
#endif
        return (var_out);
    }

    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : shl                                                     |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Arithmetically shift the 16 bit input var1 left var2 positions.Zero fill|
     |   the var2 LSB of the result. If var2 is negative, arithmetically shift   |
     |   var1 right by -var2 with sign extension. Saturate the result in case of |
     |   underflows or overflows.                                                |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    var1                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |    var2                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    var_out                                                                |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var_out <= 0x0000 7fff.                |
     |___________________________________________________________________________|
    */
    public static Word16 shl(Word16 var1, Word16 var2)
    {
        Word16 var_out;
        Word32 result;

        if (var2 < 0)
        {
            if (var2 < -16)
                var2 = -16;
            var2 = (Word16)(-var2);
            var_out = shr(var1, var2);

#if (WMOPS)
            multiCounter[currCounter].shr--;
#endif
        }
        else
        {
            result = (Word32)var1 * ((Word32)1 << var2);

            if ((var2 > 15 && var1 != 0) || (result != (Word32)((Word16)result)))
            {
                Overflow = 1;
                var_out = (var1 > 0) ? MAX_16 : MIN_16;
            }
            else
            {
                var_out = extract_l(result);

#if (WMOPS)
                multiCounter[currCounter].extract_l--;
#endif
            }
        }

#if (WMOPS)
        multiCounter[currCounter].shl++;
#endif
        return (var_out);
    }

    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : shr                                                     |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Arithmetically shift the 16 bit input var1 right var2 positions with    |
     |   sign extension. If var2 is negative, arithmetically shift var1 left by  |
     |   -var2 with sign extension. Saturate the result in case of underflows or |
     |   overflows.                                                              |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    var1                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |    var2                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    var_out                                                                |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var_out <= 0x0000 7fff.                |
     |___________________________________________________________________________|
    */
    public static Word16 shr(Word16 var1, Word16 var2)
    {
        Word16 var_out;

        if (var2 < 0)
        {
            if (var2 < -16)
                var2 = -16;
            var2 = (Word16)(-var2);
            var_out = shl(var1, var2);

#if (WMOPS)
            multiCounter[currCounter].shl--;
#endif
        }
        else
        {
            if (var2 >= 15)
            {
                var_out = (Word16)((var1 < 0) ? -1 : 0);
            }
            else
            {
                if (var1 < 0)
                {
                    var_out = (Word16)~((~var1) >> var2);
                }
                else
                {
                    var_out = (Word16)(var1 >> var2);
                }
            }
        }

#if (WMOPS)
        multiCounter[currCounter].shr++;
#endif
        return (var_out);
    }

    /*___________________________________________________________________________
 |                                                                           |
 |   Function Name : mult                                                    |
 |                                                                           |
 |   Purpose :                                                               |
 |                                                                           |
 |    Performs the multiplication of var1 by var2 and gives a 16 bit result  |
 |    which is scaled i.e.:                                                  |
 |             mult(var1,var2) = extract_l(L_shr((var1 times var2),15)) and  |
 |             mult(-32768,-32768) = 32767.                                  |
 |                                                                           |
 |   Complexity weight : 1                                                   |
 |                                                                           |
 |   Inputs :                                                                |
 |                                                                           |
 |    var1                                                                   |
 |             16 bit short signed integer (Word16) whose value falls in the |
 |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
 |                                                                           |
 |    var2                                                                   |
 |             16 bit short signed integer (Word16) whose value falls in the |
 |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
 |                                                                           |
 |   Outputs :                                                               |
 |                                                                           |
 |    none                                                                   |
 |                                                                           |
 |   Return Value :                                                          |
 |                                                                           |
 |    var_out                                                                |
 |             16 bit short signed integer (Word16) whose value falls in the |
 |             range : 0xffff 8000 <= var_out <= 0x0000 7fff.                |
 |___________________________________________________________________________|
*/
    public static Word16 mult(Word16 var1, Word16 var2)
    {
        unchecked
        {

            Word16 var_out;
            Word32 L_product;

            L_product = (Word32)var1 * (Word32)var2;

            L_product = (L_product & (Word32)0xffff8000L) >> 15;

            if ((L_product & (Word32)0x00010000L) != 0)
                L_product = L_product | (Word32)0xffff0000L;

            var_out = saturate(L_product);

#if (WMOPS)
            multiCounter[currCounter].mult++;
#endif
            return (var_out);
        }
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : L_mult                                                  |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   L_mult is the 32 bit result of the multiplication of var1 times var2    |
     |   with one shift left i.e.:                                               |
     |        L_mult(var1,var2) = L_shl((var1 times var2),1) and                 |
     |        L_mult(-32768,-32768) = 2147483647.                                |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    var1                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |    var2                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    L_var_out                                                              |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.              |
     |___________________________________________________________________________|
    */
    public static Word32 L_mult(Word16 var1, Word16 var2)
    {
        Word32 L_var_out;

        L_var_out = (Word32)var1 * (Word32)var2;

        if (L_var_out != (Word32)0x40000000L)
        {
            L_var_out *= 2;
        }
        else
        {
            Overflow = 1;
            L_var_out = MAX_32;
        }

#if (WMOPS)
        multiCounter[currCounter].L_mult++;
#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : negate                                                  |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Negate var1 with saturation, saturate in the case where input is -32768:|
     |                negate(var1) = sub(0,var1).                                |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    var1                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    var_out                                                                |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var_out <= 0x0000 7fff.                |
     |___________________________________________________________________________|
    */
    public static Word16 negate(Word16 var1)
    {
        Word16 var_out;

        var_out = (Word16)((var1 == MIN_16) ? MAX_16 : -var1);

#if (WMOPS)
        multiCounter[currCounter].negate++;
#endif
        return (var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : extract_h                                               |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Return the 16 MSB of L_var1.                                            |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var1                                                                 |
     |             32 bit long signed integer (Word32 ) whose value falls in the |
     |             range : 0x8000 0000 <= L_var1 <= 0x7fff ffff.                 |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    var_out                                                                |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var_out <= 0x0000 7fff.                |
     |___________________________________________________________________________|
    */
    public static Word16 extract_h(Word32 L_var1)
    {
        Word16 var_out;

        var_out = (Word16)(L_var1 >> 16);

#if (WMOPS)
        multiCounter[currCounter].extract_h++;
#endif
        return (var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : extract_l                                               |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Return the 16 LSB of L_var1.                                            |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var1                                                                 |
     |             32 bit long signed integer (Word32 ) whose value falls in the |
     |             range : 0x8000 0000 <= L_var1 <= 0x7fff ffff.                 |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    var_out                                                                |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var_out <= 0x0000 7fff.                |
     |___________________________________________________________________________|
    */
    public static Word16 extract_l(Word32 L_var1)
    {
        Word16 var_out;

        var_out = (Word16)L_var1;

#if (WMOPS)
        multiCounter[currCounter].extract_l++;
#endif
        return (var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : round_fx                                                |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Round the lower 16 bits of the 32 bit input number into the MS 16 bits  |
     |   with saturation. Shift the resulting bits right by 16 and return the 16 |
     |   bit number:                                                             |
     |               round_fx(L_var1) = extract_h(L_add(L_var1,32768))           |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var1                                                                 |
     |             32 bit long signed integer (Word32 ) whose value falls in the |
     |             range : 0x8000 0000 <= L_var1 <= 0x7fff ffff.                 |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    var_out                                                                |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var_out <= 0x0000 7fff.                |
     |___________________________________________________________________________|
    */
    public static Word16 round_fx(Word32 L_var1)
    {
        Word16 var_out;
        Word32 L_rounded;

        L_rounded = L_add(L_var1, (Word32)0x00008000L);
        var_out = extract_h(L_rounded);

#if (WMOPS)
        multiCounter[currCounter].L_add--;
        multiCounter[currCounter].extract_h--;
        multiCounter[currCounter].round++;
#endif
        return (var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : L_mac                                                   |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Multiply var1 by var2 and shift the result left by 1. Add the 32 bit    |
     |   result to L_var3 with saturation, return a 32 bit result:               |
     |        L_mac(L_var3,var1,var2) = L_add(L_var3,L_mult(var1,var2)).         |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var3   32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.                 |
     |                                                                           |
     |    var1                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |    var2                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    L_var_out                                                              |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.              |
     |___________________________________________________________________________|
    */
    public static Word32 L_mac(Word32 L_var3, Word16 var1, Word16 var2)
    {
        Word32 L_var_out;
        Word32 L_product;

        L_product = L_mult(var1, var2);
        L_var_out = L_add(L_var3, L_product);

#if (WMOPS)
        multiCounter[currCounter].L_mult--;
        multiCounter[currCounter].L_add--;
        multiCounter[currCounter].L_mac++;
#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : L_msu                                                   |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Multiply var1 by var2 and shift the result left by 1. Subtract the 32   |
     |   bit result from L_var3 with saturation, return a 32 bit result:         |
     |        L_msu(L_var3,var1,var2) = L_sub(L_var3,L_mult(var1,var2)).         |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var3   32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.                 |
     |                                                                           |
     |    var1                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |    var2                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    L_var_out                                                              |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.              |
     |___________________________________________________________________________|
    */
    public static Word32 L_msu(Word32 L_var3, Word16 var1, Word16 var2)
    {
        Word32 L_var_out;
        Word32 L_product;

        L_product = L_mult(var1, var2);
        L_var_out = L_sub(L_var3, L_product);

#if (WMOPS)
        multiCounter[currCounter].L_mult--;
        multiCounter[currCounter].L_sub--;
        multiCounter[currCounter].L_msu++;
#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : L_macNs                                                 |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Multiply var1 by var2 and shift the result left by 1. Add the 32 bit    |
     |   result to L_var3 without saturation, return a 32 bit result. Generate   |
     |   carry and overflow values :                                             |
     |        L_macNs(L_var3,var1,var2) = L_add_c(L_var3,L_mult(var1,var2)).     |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var3   32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.                 |
     |                                                                           |
     |    var1                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |    var2                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    L_var_out                                                              |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.              |
     |                                                                           |
     |   Caution :                                                               |
     |                                                                           |
     |    In some cases the Carry flag has to be cleared or set before using     |
     |    operators which take into account its value.                           |
     |___________________________________________________________________________|
    */
    public static Word32 L_macNs(Word32 L_var3, Word16 var1, Word16 var2)
    {
        Word32 L_var_out;

        L_var_out = L_mult(var1, var2);
        L_var_out = L_add_c(L_var3, L_var_out);

#if (WMOPS)
        multiCounter[currCounter].L_mult--;
        multiCounter[currCounter].L_add_c--;
        multiCounter[currCounter].L_macNs++;
#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : L_msuNs                                                 |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Multiply var1 by var2 and shift the result left by 1. Subtract the 32   |
     |   bit result from L_var3 without saturation, return a 32 bit result. Ge-  |
     |   nerate carry and overflow values :                                      |
     |        L_msuNs(L_var3,var1,var2) = L_sub_c(L_var3,L_mult(var1,var2)).     |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var3   32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.                 |
     |                                                                           |
     |    var1                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |    var2                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    L_var_out                                                              |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.              |
     |                                                                           |
     |   Caution :                                                               |
     |                                                                           |
     |    In some cases the Carry flag has to be cleared or set before using     |
     |    operators which take into account its value.                           |
     |___________________________________________________________________________|
    */
    public static Word32 L_msuNs(Word32 L_var3, Word16 var1, Word16 var2)
    {
        Word32 L_var_out;

        L_var_out = L_mult(var1, var2);
        L_var_out = L_sub_c(L_var3, L_var_out);

#if (WMOPS)
        multiCounter[currCounter].L_mult--;
        multiCounter[currCounter].L_sub_c--;
        multiCounter[currCounter].L_msuNs++;

#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : L_add                                                   |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   32 bits addition of the two 32 bits variables (L_var1+L_var2) with      |
     |   overflow control and saturation; the result is set at +2147483647 when  |
     |   overflow occurs or at -2147483648 when underflow occurs.                |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var1   32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.                 |
     |                                                                           |
     |    L_var2   32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.                 |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    L_var_out                                                              |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.              |
     |___________________________________________________________________________|
    */
    public static Word32 L_add(Word32 L_var1, Word32 L_var2)
    {
        Word32 L_var_out;

        L_var_out = L_var1 + L_var2;

        if (((L_var1 ^ L_var2) & MIN_32) == 0)
        {
            if (((L_var_out ^ L_var1) & MIN_32) != 0)
            {
                L_var_out = (L_var1 < 0) ? MIN_32 : MAX_32;
                Overflow = 1;
            }
        }
#if (WMOPS)
        multiCounter[currCounter].L_add++;
#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : L_sub                                                   |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   32 bits subtraction of the two 32 bits variables (L_var1-L_var2) with   |
     |   overflow control and saturation; the result is set at +2147483647 when  |
     |   overflow occurs or at -2147483648 when underflow occurs.                |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var1   32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.                 |
     |                                                                           |
     |    L_var2   32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.                 |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    L_var_out                                                              |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.              |
     |___________________________________________________________________________|
    */
    public static Word32 L_sub(Word32 L_var1, Word32 L_var2)
    {
        Word32 L_var_out;

        L_var_out = L_var1 - L_var2;

        if (((L_var1 ^ L_var2) & MIN_32) != 0)
        {
            if (((L_var_out ^ L_var1) & MIN_32) != 0)
            {
                L_var_out = (L_var1 < 0L) ? MIN_32 : MAX_32;
                Overflow = 1;
            }
        }
#if (WMOPS)
        multiCounter[currCounter].L_sub++;
#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : L_add_c                                                 |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Performs 32 bits addition of the two 32 bits variables (L_var1+L_var2+C)|
     |   with carry. No saturation. Generate carry and Overflow values. The car- |
     |   ry and overflow values are binary variables which can be tested and as- |
     |   signed values.                                                          |
     |                                                                           |
     |   Complexity weight : 2                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var1   32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.                 |
     |                                                                           |
     |    L_var2   32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.                 |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    L_var_out                                                              |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.              |
     |                                                                           |
     |   Caution :                                                               |
     |                                                                           |
     |    In some cases the Carry flag has to be cleared or set before using     |
     |    operators which take into account its value.                           |
     |___________________________________________________________________________|
    */
    public static Word32 L_add_c(Word32 L_var1, Word32 L_var2)
    {
        Word32 L_var_out;
        Word32 L_test;
        Flag carry_int = 0;

        L_var_out = L_var1 + L_var2 + Carry;

        L_test = L_var1 + L_var2;

        if ((L_var1 > 0) && (L_var2 > 0) && (L_test < 0))
        {
            Overflow = 1;
            carry_int = 0;
        }
        else
        {
            if ((L_var1 < 0) && (L_var2 < 0))
            {
                if (L_test >= 0)
                {
                    Overflow = 1;
                    carry_int = 1;
                }
                else
                {
                    Overflow = 0;
                    carry_int = 1;
                }
            }
            else
            {
                if (((L_var1 ^ L_var2) < 0) && (L_test >= 0))
                {
                    Overflow = 0;
                    carry_int = 1;
                }
                else
                {
                    Overflow = 0;
                    carry_int = 0;
                }
            }
        }

        if (Carry == 1)
        {
            if (L_test == MAX_32)
            {
                Overflow = 1;
                Carry = carry_int;
            }
            else
            {
                if (L_test == unchecked((Word32)0xFFFFFFFFL))
                {
                    Carry = 1;
                }
                else
                {
                    Carry = carry_int;
                }
            }
        }
        else
        {
            Carry = carry_int;
        }

#if (WMOPS)
        multiCounter[currCounter].L_add_c++;
#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : L_sub_c                                                 |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Performs 32 bits subtraction of the two 32 bits variables with carry    |
     |   (borrow) : L_var1-L_var2-C. No saturation. Generate carry and Overflow  |
     |   values. The carry and overflow values are binary variables which can    |
     |   be tested and assigned values.                                          |
     |                                                                           |
     |   Complexity weight : 2                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var1   32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.                 |
     |                                                                           |
     |    L_var2   32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.                 |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    L_var_out                                                              |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.              |
     |                                                                           |
     |   Caution :                                                               |
     |                                                                           |
     |    In some cases the Carry flag has to be cleared or set before using     |
     |    operators which take into account its value.                           |
     |___________________________________________________________________________|
    */
    public static Word32 L_sub_c(Word32 L_var1, Word32 L_var2)
    {
        Word32 L_var_out;
        Word32 L_test;
        Flag carry_int = 0;

        if (Carry == 1)
        {
            Carry = 0;
            if (L_var2 != MIN_32)
            {
                L_var_out = L_add_c(L_var1, -L_var2);
#if (WMOPS)
                multiCounter[currCounter].L_add_c--;
#endif
            }
            else
            {
                L_var_out = L_var1 - L_var2;
                if (L_var1 > 0L)
                {
                    Overflow = 1;
                    Carry = 0;
                }
            }
        }
        else
        {
            L_var_out = L_var1 - L_var2 - (Word32)0X00000001L;
            L_test = L_var1 - L_var2;

            if ((L_test < 0) && (L_var1 > 0) && (L_var2 < 0))
            {
                Overflow = 1;
                carry_int = 0;
            }
            else if ((L_test > 0) && (L_var1 < 0) && (L_var2 > 0))
            {
                Overflow = 1;
                carry_int = 1;
            }
            else if ((L_test > 0) && ((L_var1 ^ L_var2) > 0))
            {
                Overflow = 0;
                carry_int = 1;
            }
            if (L_test == MIN_32)
            {
                Overflow = 1;
                Carry = carry_int;
            }
            else
            {
                Carry = carry_int;
            }
        }

#if (WMOPS)
        multiCounter[currCounter].L_sub_c++;
#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : L_negate                                                |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Negate the 32 bit variable L_var1 with saturation; saturate in the case |
     |   where input is -2147483648 (0x8000 0000).                               |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var1   32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.                 |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    L_var_out                                                              |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.              |
     |___________________________________________________________________________|
    */
    public static Word32 L_negate(Word32 L_var1)
    {
        Word32 L_var_out;

        L_var_out = (L_var1 == MIN_32) ? MAX_32 : -L_var1;

#if (WMOPS)
        multiCounter[currCounter].L_negate++;
#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : mult_r                                                  |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Same as mult with rounding, i.e.:                                       |
     |     mult_r(var1,var2) = extract_l(L_shr(((var1 * var2) + 16384),15)) and  |
     |     mult_r(-32768,-32768) = 32767.                                        |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    var1                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |    var2                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    var_out                                                                |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0x8000 <= var_out <= 0x7fff.                          |
     |___________________________________________________________________________|
    */
    public static Word16 mult_r(Word16 var1, Word16 var2)
    {
        unchecked
        {
            Word16 var_out;
            Word32 L_product_arr;

            L_product_arr = (Word32)var1 * (Word32)var2; /* product */
            L_product_arr += (Word32)0x00004000L;        /* round */
            L_product_arr &= (Word32)0xffff8000L;
            L_product_arr >>= 15;         /* shift */

            if ((L_product_arr & (Word32)0x00010000L) != 0)
            {   /* sign extend when necessary */
                L_product_arr |= (Word32)0xffff0000L;
            }
            var_out = saturate(L_product_arr);

#if (WMOPS)
            multiCounter[currCounter].mult_r++;
#endif
            return (var_out);
        }
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : L_shl                                                   |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Arithmetically shift the 32 bit input L_var1 left var2 positions. Zero  |
     |   fill the var2 LSB of the result. If var2 is negative, arithmetically    |
     |   shift L_var1 right by -var2 with sign extension. Saturate the result in |
     |   case of underflows or overflows.                                        |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var1   32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.                 |
     |                                                                           |
     |    var2                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    L_var_out                                                              |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.              |
     |___________________________________________________________________________|
    */
    public static Word32 L_shl(Word32 L_var1, Word16 var2)
    {

        Word32 L_var_out = 0;

        if (var2 <= 0)
        {
            if (var2 < -32)
                var2 = -32;
            var2 = (Word16)(-var2);
            L_var_out = L_shr(L_var1, var2);
#if (WMOPS)
            multiCounter[currCounter].L_shr--;
#endif
        }
        else
        {
            for (; var2 > 0; var2--)
            {
                if (L_var1 > (Word32)0X3fffffffL)
                {
                    Overflow = 1;
                    L_var_out = MAX_32;
                    break;
                }
                else
                {
                    if (L_var1 < unchecked((Word32)0xc0000000L))
                    {
                        Overflow = 1;
                        L_var_out = MIN_32;
                        break;
                    }
                }
                L_var1 *= 2;
                L_var_out = L_var1;
            }
        }
#if (WMOPS)
        multiCounter[currCounter].L_shl++;
#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : L_shr                                                   |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Arithmetically shift the 32 bit input L_var1 right var2 positions with  |
     |   sign extension. If var2 is negative, arithmetically shift L_var1 left   |
     |   by -var2 and zero fill the -var2 LSB of the result. Saturate the result |
     |   in case of underflows or overflows.                                     |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var1   32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.                 |
     |                                                                           |
     |    var2                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    L_var_out                                                              |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.              |
     |___________________________________________________________________________|
    */
    public static Word32 L_shr(Word32 L_var1, Word16 var2)
    {
        Word32 L_var_out;

        if (var2 < 0)
        {
            if (var2 < -32)
                var2 = -32;
            var2 = (Word16)(-var2);
            L_var_out = L_shl(L_var1, var2);
#if (WMOPS)
            multiCounter[currCounter].L_shl--;
#endif
        }
        else
        {
            if (var2 >= 31)
            {
                L_var_out = (L_var1 < 0L) ? -1 : 0;
            }
            else
            {
                if (L_var1 < 0)
                {
                    L_var_out = ~((~L_var1) >> var2);
                }
                else
                {
                    L_var_out = L_var1 >> var2;
                }
            }
        }
#if (WMOPS)
        multiCounter[currCounter].L_shr++;
#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : shr_r                                                   |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Same as shr(var1,var2) but with rounding. Saturate the result in case of|
     |   underflows or overflows :                                               |
     |    - If var2 is greater than zero :                                       |
     |          if (sub(shl(shr(var1,var2),1),shr(var1,sub(var2,1))))            |
     |          is equal to zero                                                 |
     |                     then                                                  |
     |                     shr_r(var1,var2) = shr(var1,var2)                     |
     |                     else                                                  |
     |                     shr_r(var1,var2) = add(shr(var1,var2),1)              |
     |    - If var2 is less than or equal to zero :                              |
     |                     shr_r(var1,var2) = shr(var1,var2).                    |
     |                                                                           |
     |   Complexity weight : 3                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    var1                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |    var2                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    var_out                                                                |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var_out <= 0x0000 7fff.                |
     |___________________________________________________________________________|
    */
    public static Word16 shr_r(Word16 var1, Word16 var2)
    {
        Word16 var_out;

        if (var2 > 15)
        {
            var_out = 0;
        }
        else
        {
            var_out = shr(var1, var2);

#if (WMOPS)
            multiCounter[currCounter].shr--;
#endif

            if (var2 > 0)
            {
                if ((var1 & ((Word16)1 << (var2 - 1))) != 0)
                {
                    var_out++;
                }
            }
        }

#if (WMOPS)
        multiCounter[currCounter].shr_r++;
#endif
        return (var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : mac_r                                                   |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Multiply var1 by var2 and shift the result left by 1. Add the 32 bit    |
     |   result to L_var3 with saturation. Round the LS 16 bits of the result    |
     |   into the MS 16 bits with saturation and shift the result right by 16.   |
     |   Return a 16 bit result.                                                 |
     |            mac_r(L_var3,var1,var2) = round_fx(L_mac(L_var3,var1,var2))    |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var3   32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.                 |
     |                                                                           |
     |    var1                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |    var2                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    var_out                                                                |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0x0000 8000 <= L_var_out <= 0x0000 7fff.              |
     |___________________________________________________________________________|
    */
    public static Word16 mac_r(Word32 L_var3, Word16 var1, Word16 var2)
    {
        Word16 var_out;

        L_var3 = L_mac(L_var3, var1, var2);
        L_var3 = L_add(L_var3, (Word32)0x00008000L);
        var_out = extract_h(L_var3);

#if (WMOPS)
        multiCounter[currCounter].L_mac--;
        multiCounter[currCounter].L_add--;
        multiCounter[currCounter].extract_h--;
        multiCounter[currCounter].mac_r++;
#endif
        return (var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : msu_r                                                   |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Multiply var1 by var2 and shift the result left by 1. Subtract the 32   |
     |   bit result from L_var3 with saturation. Round the LS 16 bits of the res-|
     |   ult into the MS 16 bits with saturation and shift the result right by   |
     |   16. Return a 16 bit result.                                             |
     |            msu_r(L_var3,var1,var2) = round_fx(L_msu(L_var3,var1,var2))    |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var3   32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.                 |
     |                                                                           |
     |    var1                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |    var2                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    var_out                                                                |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0x0000 8000 <= L_var_out <= 0x0000 7fff.              |
     |___________________________________________________________________________|
    */
    public static Word16 msu_r(Word32 L_var3, Word16 var1, Word16 var2)
    {
        Word16 var_out;

        L_var3 = L_msu(L_var3, var1, var2);
        L_var3 = L_add(L_var3, (Word32)0x00008000L);
        var_out = extract_h(L_var3);

#if (WMOPS)
        multiCounter[currCounter].L_msu--;
        multiCounter[currCounter].L_add--;
        multiCounter[currCounter].extract_h--;
        multiCounter[currCounter].msu_r++;
#endif
        return (var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : L_deposit_h                                             |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Deposit the 16 bit var1 into the 16 MS bits of the 32 bit output. The   |
     |   16 LS bits of the output are zeroed.                                    |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    var1                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    L_var_out                                                              |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= var_out <= 0x7fff 0000.                |
     |___________________________________________________________________________|
    */
    public static Word32 L_deposit_h(Word16 var1)
    {
        Word32 L_var_out;

        L_var_out = (Word32)var1 << 16;

#if (WMOPS)
        multiCounter[currCounter].L_deposit_h++;
#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : L_deposit_l                                             |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Deposit the 16 bit var1 into the 16 LS bits of the 32 bit output. The   |
     |   16 MS bits of the output are sign extended.                             |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    var1                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    L_var_out                                                              |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0xFFFF 8000 <= var_out <= 0x0000 7fff.                |
     |___________________________________________________________________________|
    */
    public static Word32 L_deposit_l(Word16 var1)
    {
        Word32 L_var_out;

        L_var_out = (Word32)var1;

#if (WMOPS)
        multiCounter[currCounter].L_deposit_l++;
#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : L_shr_r                                                 |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Same as L_shr(L_var1,var2) but with rounding. Saturate the result in    |
     |   case of underflows or overflows :                                       |
     |    - If var2 is greater than zero :                                       |
     |          if (L_sub(L_shl(L_shr(L_var1,var2),1),L_shr(L_var1,sub(var2,1))))|
     |          is equal to zero                                                 |
     |                     then                                                  |
     |                     L_shr_r(L_var1,var2) = L_shr(L_var1,var2)             |
     |                     else                                                  |
     |                     L_shr_r(L_var1,var2) = L_add(L_shr(L_var1,var2),1)    |
     |    - If var2 is less than or equal to zero :                              |
     |                     L_shr_r(L_var1,var2) = L_shr(L_var1,var2).            |
     |                                                                           |
     |   Complexity weight : 3                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var1                                                                 |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= var1 <= 0x7fff ffff.                   |
     |                                                                           |
     |    var2                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    L_var_out                                                              |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= var_out <= 0x7fff ffff.                |
     |___________________________________________________________________________|
    */
    public static Word32 L_shr_r(Word32 L_var1, Word16 var2)
    {
        Word32 L_var_out;

        if (var2 > 31)
        {
            L_var_out = 0;
        }
        else
        {
            L_var_out = L_shr(L_var1, var2);

#if (WMOPS)
            multiCounter[currCounter].L_shr--;
#endif
            if (var2 > 0)
            {
                if ((L_var1 & ((Word32)1 << (var2 - 1))) != 0)
                {
                    L_var_out++;
                }
            }
        }

#if (WMOPS)
        multiCounter[currCounter].L_shr_r++;
#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : L_abs                                                   |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |    Absolute value of L_var1; Saturate in case where the input is          |
     |                                                               -214783648  |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var1                                                                 |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= var1 <= 0x7fff ffff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    L_var_out                                                              |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x0000 0000 <= var_out <= 0x7fff ffff.                |
     |___________________________________________________________________________|
    */
    public static Word32 L_abs(Word32 L_var1)
    {
        Word32 L_var_out;

        if (L_var1 == MIN_32)
        {
            L_var_out = MAX_32;
        }
        else
        {
            if (L_var1 < 0)
            {
                L_var_out = -L_var1;
            }
            else
            {
                L_var_out = L_var1;
            }
        }

#if (WMOPS)
        multiCounter[currCounter].L_abs++;
#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : L_sat                                                   |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |    32 bit L_var1 is set to 2147483647 if an overflow occured or to        |
     |    -2147483648 if an underflow occured on the most recent L_add_c,        |
     |    L_sub_c, L_macNs or L_msuNs operations. The carry and overflow values  |
     |    are binary values which can be tested and assigned values.             |
     |                                                                           |
     |   Complexity weight : 4                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var1                                                                 |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= var1 <= 0x7fff ffff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    L_var_out                                                              |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= var_out <= 0x7fff ffff.                |
     |___________________________________________________________________________|
    */
    public static Word32 L_sat(Word32 L_var1)
    {
        Word32 L_var_out;

        L_var_out = L_var1;

        if (Overflow == 1)
        {

            if (Carry == 1)
            {
                L_var_out = MIN_32;
            }
            else
            {
                L_var_out = MAX_32;
            }

            Carry = 0;
            Overflow = 0;
        }
#if (WMOPS)
        multiCounter[currCounter].L_sat++;
#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : norm_s                                                  |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Produces the number of left shift needed to normalize the 16 bit varia- |
     |   ble var1 for positive values on the interval with minimum of 16384 and  |
     |   maximum of 32767, and for negative values on the interval with minimum  |
     |   of -32768 and maximum of -16384; in order to normalize the result, the  |
     |   following operation must be done :                                      |
     |                    norm_var1 = shl(var1,norm_s(var1)).                    |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    var1                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    var_out                                                                |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0x0000 0000 <= var_out <= 0x0000 000f.                |
     |___________________________________________________________________________|
    */
    public static Word16 norm_s(Word16 var1)
    {
        Word16 var_out;

        if (var1 == 0)
        {
            var_out = 0;
        }
        else
        {
            if (var1 == unchecked((Word16)0xffff))
            {
                var_out = 15;
            }
            else
            {
                if (var1 < 0)
                {
                    var1 = (Word16)(~var1);
                }
                for (var_out = 0; var1 < 0x4000; var_out++)
                {
                    var1 <<= 1;
                }
            }
        }

#if (WMOPS)
        multiCounter[currCounter].norm_s++;
#endif
        return (var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : div_s                                                   |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Produces a result which is the fractional integer division of var1  by  |
     |   var2; var1 and var2 must be positive and var2 must be greater or equal  |
     |   to var1; the result is positive (leading bit equal to 0) and truncated  |
     |   to 16 bits.                                                             |
     |   If var1 = var2 then div(var1,var2) = 32767.                             |
     |                                                                           |
     |   Complexity weight : 18                                                  |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    var1                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0x0000 0000 <= var1 <= var2 and var2 != 0.            |
     |                                                                           |
     |    var2                                                                   |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : var1 <= var2 <= 0x0000 7fff and var2 != 0.            |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    var_out                                                                |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0x0000 0000 <= var_out <= 0x0000 7fff.                |
     |             It's a Q15 value (point between b15 and b14).                 |
     |___________________________________________________________________________|
    */
    public static Word16 div_s(Word16 var1, Word16 var2)
    {
        Word16 var_out = 0;
        Word16 iteration;
        Word32 L_num;
        Word32 L_denom;

        if ((var1 > var2) || (var1 < 0) || (var2 < 0))
        {
            throw new BasopRuntimeException($"Division Error var1={var1}  var2={var2}\n");
        }
        if (var2 == 0)
        {
            throw new BasopRuntimeException("Division by 0, Fatal error \n");
        }
        if (var1 == 0)
        {
            var_out = 0;
        }
        else
        {
            if (var1 == var2)
            {
                var_out = MAX_16;
            }
            else
            {
                L_num = L_deposit_l(var1);
                L_denom = L_deposit_l(var2);

#if (WMOPS)
                multiCounter[currCounter].L_deposit_l--;
                multiCounter[currCounter].L_deposit_l--;
#endif

                for (iteration = 0; iteration < 15; iteration++)
                {
                    var_out <<= 1;
                    L_num <<= 1;

                    if (L_num >= L_denom)
                    {
                        L_num = L_sub(L_num, L_denom);
                        var_out = add(var_out, 1);
#if (WMOPS)
                        multiCounter[currCounter].L_sub--;
                        multiCounter[currCounter].add--;
#endif
                    }
                }
            }
        }

#if (WMOPS)
        multiCounter[currCounter].div_s++;
#endif
        return (var_out);
    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : norm_l                                                  |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Produces the number of left shifts needed to normalize the 32 bit varia-|
     |   ble L_var1 for positive values on the interval with minimum of          |
     |   1073741824 and maximum of 2147483647, and for negative values on the in-|
     |   terval with minimum of -2147483648 and maximum of -1073741824; in order |
     |   to normalize the result, the following operation must be done :         |
     |                   norm_L_var1 = L_shl(L_var1,norm_l(L_var1)).             |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |    L_var1                                                                 |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= var1 <= 0x7fff ffff.                   |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    var_out                                                                |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0x0000 0000 <= var_out <= 0x0000 001f.                |
     |___________________________________________________________________________|
    */
    public static Word16 norm_l(Word32 L_var1)
    {
        Word16 var_out;

        if (L_var1 == 0)
        {
            var_out = 0;
        }
        else
        {
            if (L_var1 == unchecked((Word32)0xffffffffL))
            {
                var_out = 31;
            }
            else
            {
                if (L_var1 < 0)
                {
                    L_var1 = ~L_var1;
                }
                for (var_out = 0; L_var1 < (Word32)0x40000000L; var_out++)
                {
                    L_var1 <<= 1;
                }
            }
        }

#if (WMOPS)
        multiCounter[currCounter].norm_l++;
#endif
        return (var_out);
    }

    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : L_mls                                                   |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   Multiplies a 16 bit word v by a 32 bit word Lv and returns a 32 bit     |
     |   word (multiplying 16 by 32 bit words gives 48 bit word; the function    |
     |   extracts the 32 MSB and shift the result to the left by 1).             |
     |                                                                           |
     |   A 32 bit word can be written as                                         |
     |    Lv = a  +  b * 2^16                                                    |
     |   where a= unsigned 16 LSBs and b= signed 16 MSBs.                        |
     |   The function returns v * Lv  /  2^15  which is equivalent to            |
     |        a*v / 2^15 + b*v*2                                                 |
     |                                                                           |
     |   Complexity weight : 5													 |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |   Lv                                                                      |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= var1 <= 0x7fff ffff.                   |
     |   v                                                                       |
     |             16 bit short signed integer (Word16) whose value falls in the |
     |             range : 0x8000 <= var1 <= 0x7fff.                             |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    var_out                                                                |
     |             32 bit long signed integer (Word32) whose value falls in the  |
     |             range : 0x8000 0000 <= var_out <= 0x7fff ffff.                |
     |                                                                           |
     |___________________________________________________________________________|
    */
    public static Word32 L_mls(Word32 Lv, Word16 v)
    {
        Word32 Temp;

        Temp = Lv & (Word32)0x0000ffff;
        Temp = Temp * (Word32)v;
        Temp = L_shr(Temp, (Word16)15);
        Temp = L_mac(Temp, v, extract_h(Lv));

#if (WMOPS)
        multiCounter[currCounter].L_shr--;
        multiCounter[currCounter].L_mac--;
        multiCounter[currCounter].extract_h--;
        multiCounter[currCounter].L_mls++;
#endif

        return Temp;
    }


    /*__________________________________________________________________________
    |                                                                           |
    |   Function Name : div_l                                                   |
    |                                                                           |
    |   Purpose :                                                               |
    |                                                                           |
    |   Produces a result which is the fractional integer division of L_var1 by |
    |   var2; L_var1 and var2 must be positive and var2 << 16 must be greater or|
    |   equal to L_var1; the result is positive (leading bit equal to 0) and    |
    |   truncated to 16 bits.                                                   |
    |   If L_var1 == var2 << 16 then div_l(L_var1,var2) = 32767.                |
    |                                                                           |
    |   Complexity weight : 32                                                  |
    |                                                                           |
    |   Inputs :                                                                |
    |                                                                           |
    |    L_var1                                                                 |
    |             32 bit long signed integer (Word32) whose value falls in the  |
    |             range : 0x0000 0000 <= var1 <= (var2 << 16)  and var2 != 0.   |
    |             L_var1 must be considered as a Q.31 value                     |
    |                                                                           |
    |    var2                                                                   |
    |             16 bit short signed integer (Word16) whose value falls in the |
    |             range : var1 <= (var2<< 16) <= 0x7fff0000 and var2 != 0.      |
    |             var2 must be considered as a Q.15 value                       |
    |                                                                           |
    |   Outputs :                                                               |
    |                                                                           |
    |    none                                                                   |
    |                                                                           |
    |   Return Value :                                                          |
    |                                                                           |
    |    var_out                                                                |
    |             16 bit short signed integer (Word16) whose value falls in the |
    |             range : 0x0000 0000 <= var_out <= 0x0000 7fff.                |
    |             It's a Q15 value (point between b15 and b14).                 |
    |___________________________________________________________________________|
    */
    public static Word16 div_l(Word32 L_num, Word16 den)
    {
        Word16 var_out = (Word16)0;
        Word32 L_den;
        Word16 iteration;

#if (WMOPS)
        multiCounter[currCounter].div_l++;
#endif

        if (den == (Word16)0)
        {
            throw new BasopRuntimeException("Division by 0 in div_l, Fatal error \n");
        }

        if ((L_num < (Word32)0) || (den < (Word16)0))
        {
            throw new BasopRuntimeException("Division Error in div_l, Fatal error \n");
        }

        L_den = L_deposit_h(den);
#if (WMOPS)
        multiCounter[currCounter].L_deposit_h--;
#endif

        if (L_num >= L_den)
        {
            return MAX_16;
        }
        else
        {
            L_num = L_shr(L_num, (Word16)1);
            L_den = L_shr(L_den, (Word16)1);
#if (WMOPS)
            multiCounter[currCounter].L_shr -= 2;
#endif
            for (iteration = (Word16)0; iteration < (Word16)15; iteration++)
            {
                var_out = shl(var_out, (Word16)1);
                L_num = L_shl(L_num, (Word16)1);
#if (WMOPS)
                multiCounter[currCounter].shl--;
                multiCounter[currCounter].L_shl--;
#endif
                if (L_num >= L_den)
                {
                    L_num = L_sub(L_num, L_den);
                    var_out = add(var_out, (Word16)1);
#if (WMOPS)
                    multiCounter[currCounter].L_sub--;
                    multiCounter[currCounter].add--;
#endif
                }
            }

            return var_out;
        }
    }


    /*__________________________________________________________________________
    |                                                                           |
    |   Function Name : i_mult                                                  |
    |                                                                           |
    |   Purpose :                                                               |
    |                                                                           |
    |   Integer 16-bit multiplication with overflow control.                    |
    |   No overflow protection is performed if ORIGINAL_G7231 is defined.       |
    |                                                                           |
    |   Complexity weight : 3 (it is performing something equivalent to         |
    |                          extract_h( L_shl( L_mult0( v1, v2), 16))         |
    |                                                                           |
    |   Inputs :                                                                |
    |                                                                           |
    |    a                                                                      |
    |             16 bit short signed integer (Word16).                         |
    |                                                                           |
    |    b                                                                      |
    |             16 bit short signed integer (Word16).                         |
    |                                                                           |
    |   Outputs :                                                               |
    |                                                                           |
    |    none                                                                   |
    |                                                                           |
    |   Return Value :                                                          |
    |                                                                           |
    |             16 bit short signed integer (Word16). No overflow checks      |
    |             are performed if ORIGINAL_G7231 is defined.                   |
    |___________________________________________________________________________|
    */
    public static Word16 i_mult(Word16 a, Word16 b)
    {
#if ORIGINAL_G7231
        return a * b;
#else
        Word32 c = a * b;
#if (WMOPS)
        multiCounter[currCounter].i_mult++;
#endif
        return saturate(c);
#endif
    }


    /*
     ******************************************************************************
     * The following three operators are not part of the original 
     * G.729/G.723.1 set of basic operators and implement shiftless
     * accumulation operation.
     ******************************************************************************
    */

    /*___________________________________________________________________________
     |
     |   Function Name : L_mult0
     |
     |   Purpose :
     |
     |   L_mult0 is the 32 bit result of the multiplication of var1 times var2
     |   without one left shift.
     |
     |   Complexity weight : 1
     |
     |   Inputs :
     |
     |    var1     16 bit short signed integer (Word16) whose value falls in the
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.
     |
     |    var2     16 bit short signed integer (Word16) whose value falls in the
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.
     |
     |   Return Value :
     |
     |    L_var_out
     |             32 bit long signed integer (Word32) whose value falls in the
     |             range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.
     |___________________________________________________________________________
    */
    public static Word32 L_mult0(Word16 var1, Word16 var2)
    {
        Word32 L_var_out;

        L_var_out = (Word32)var1 * (Word32)var2;

#if (WMOPS)
        multiCounter[currCounter].L_mult0++;
#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |
     |   Function Name : L_mac0
     |
     |   Purpose :
     |
     |   Multiply var1 by var2 (without left shift) and add the 32 bit result to
     |   L_var3 with saturation, return a 32 bit result:
     |        L_mac0(L_var3,var1,var2) = L_add(L_var3,(L_mult0(var1,var2)).
     |
     |   Complexity weight : 1
     |
     |   Inputs :
     |
     |    L_var3   32 bit long signed integer (Word32) whose value falls in the
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.
     |
     |    var1     16 bit short signed integer (Word16) whose value falls in the
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.
     |
     |    var2     16 bit short signed integer (Word16) whose value falls in the
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.
     |
     |   Return Value :
     |
     |    L_var_out
     |             32 bit long signed integer (Word32) whose value falls in the
     |             range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.
     |___________________________________________________________________________
    */
    public static Word32 L_mac0(Word32 L_var3, Word16 var1, Word16 var2)
    {
        Word32 L_var_out;
        Word32 L_product;

        L_product = L_mult0(var1, var2);
        L_var_out = L_add(L_var3, L_product);

#if (WMOPS)
        multiCounter[currCounter].L_mac0++;
        multiCounter[currCounter].L_mult0--;
        multiCounter[currCounter].L_add--;
#endif
        return (L_var_out);
    }


    /*___________________________________________________________________________
     |
     |   Function Name : L_msu0
     |
     |   Purpose :
     |
     |   Multiply var1 by var2 (without left shift) and subtract the 32 bit
     |   result to L_var3 with saturation, return a 32 bit result:
     |        L_msu0(L_var3,var1,var2) = L_sub(L_var3,(L_mult0(var1,var2)).
     |
     |   Complexity weight : 1
     |
     |   Inputs :
     |
     |    L_var3   32 bit long signed integer (Word32) whose value falls in the
     |             range : 0x8000 0000 <= L_var3 <= 0x7fff ffff.
     |
     |    var1     16 bit short signed integer (Word16) whose value falls in the
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.
     |
     |    var2     16 bit short signed integer (Word16) whose value falls in the
     |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.
     |
     |   Return Value :
     |
     |    L_var_out
     |             32 bit long signed integer (Word32) whose value falls in the
     |             range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.
     |___________________________________________________________________________
    */
    public static Word32 L_msu0(Word32 L_var3, Word16 var1, Word16 var2)
    {
        Word32 L_var_out;
        Word32 L_product;

        L_product = L_mult0(var1, var2);
        L_var_out = L_sub(L_var3, L_product);

#if (WMOPS)
        multiCounter[currCounter].L_msu0++;
        multiCounter[currCounter].L_mult0--;
        multiCounter[currCounter].L_sub--;
#endif
        return (L_var_out);
    }

    public static cmplx CL_shr(cmplx inp, Word32 shift_val)
    {
        cmplx @out;
        @out.re = L_shr(inp.re, (Word16)shift_val);
        @out.im = L_shr(inp.im, (Word16)shift_val);
#if (WMOPS)
        multiCounter[currCounter].CL_shr++;
        multiCounter[currCounter].L_shr--;
        multiCounter[currCounter].L_shr--;
#endif
        return @out;
    }

    public static cmplx CL_shl(cmplx inp, Word32 shift_val)
    {
        cmplx @out;
        @out.re = L_shl(inp.re, (Word16)shift_val);
        @out.im = L_shl(inp.im, (Word16)shift_val);
#if (WMOPS)
        multiCounter[currCounter].CL_shl++;
        multiCounter[currCounter].L_shl--;
        multiCounter[currCounter].L_shl--;
#endif
        return @out;
    }

    public static cmplx CL_add(cmplx inp1, cmplx inp2)
    {
        cmplx @out;
        @out.re = L_add(inp1.re, inp2.re);
        @out.im = L_add(inp1.im, inp2.im);
#if (WMOPS)
        multiCounter[currCounter].CL_add++;
        multiCounter[currCounter].L_add--;
        multiCounter[currCounter].L_add--;
#endif
        return @out;
    }

    public static cmplx CL_sub(cmplx inp1, cmplx inp2)
    {
        cmplx @out;
        @out.re = L_sub(inp1.re, inp2.re);
        @out.im = L_sub(inp1.im, inp2.im);
#if (WMOPS)
        multiCounter[currCounter].CL_sub++;
        multiCounter[currCounter].L_sub--;
        multiCounter[currCounter].L_sub--;
#endif
        return @out;
    }

    public static cmplx CL_scale(cmplx x, Word16 y)
    {
        cmplx result;
        result.re = Mpy_32_16_r(x.re, y);
        result.im = Mpy_32_16_r(x.im, y);
#if (WMOPS)
        multiCounter[currCounter].Mpy_32_16_r--;
        multiCounter[currCounter].Mpy_32_16_r--;
        multiCounter[currCounter].CL_scale++;
#endif
        return (result);
    }

    public static cmplx CL_dscale(cmplx x, Word16 y1, Word16 y2)
    {
        cmplx result;
        result.re = Mpy_32_16_r(x.re, y1);
        result.im = Mpy_32_16_r(x.im, y2);
#if (WMOPS)
        multiCounter[currCounter].Mpy_32_16_r--;
        multiCounter[currCounter].Mpy_32_16_r--;
        multiCounter[currCounter].CL_dscale++;
#endif
        return (result);
    }

    public static cmplx CL_msu_j(cmplx x, cmplx y)
    {
        cmplx result;
        result.re = L_add(x.re, y.im);
        result.im = L_sub(x.im, y.re);
#if (WMOPS)
        multiCounter[currCounter].CL_msu_j++;
        multiCounter[currCounter].L_add--;
        multiCounter[currCounter].L_sub--;
#endif
        return result;
    }

    public static cmplx CL_mac_j(cmplx x, cmplx y)
    {
        cmplx result;
        result.re = L_sub(x.re, y.im);
        result.im = L_add(x.im, y.re);
#if (WMOPS)
        multiCounter[currCounter].CL_mac_j++;
        multiCounter[currCounter].L_add--;
        multiCounter[currCounter].L_sub--;
#endif
        return result;
    }

    public static cmplx CL_move(cmplx x)
    {
#if (WMOPS)
        multiCounter[currCounter].CL_move++;
#endif
        return x;
    }

    public static Word32 CL_Extract_real(cmplx x)
    {
#if (WMOPS)
        multiCounter[currCounter].CL_Extract_real++;
#endif
        return x.re;
    }

    public static Word32 CL_Extract_imag(cmplx x)
    {
#if (WMOPS)
        multiCounter[currCounter].CL_Extract_imag++;
#endif
        return x.im;
    }

    public static cmplx CL_form(Word32 re, Word32 im)
    {
        cmplx result;
        result.re = re;
        result.im = im;
#if (WMOPS)
        multiCounter[currCounter].CL_form++;
#endif
        return result;
    }

    public static cmplx CL_multr_32x16(cmplx input, cmplx_s coeff)
    {
        cmplx result;
        result.re = W_round48_L(W_sub_nosat(W_mult_32_16(input.re, coeff.re), W_mult_32_16(input.im, coeff.im)));
        result.im = W_round48_L(W_add_nosat(W_mult_32_16(input.re, coeff.im), W_mult_32_16(input.im, coeff.re)));
#if (WMOPS)
        multiCounter[currCounter].CL_multr_32x16++;
        multiCounter[currCounter].W_mult_32_16--;
        multiCounter[currCounter].W_mult_32_16--;
        multiCounter[currCounter].W_mult_32_16--;
        multiCounter[currCounter].W_mult_32_16--;
        multiCounter[currCounter].W_sub_nosat--;
        multiCounter[currCounter].W_add_nosat--;
        multiCounter[currCounter].W_round48_L--;
        multiCounter[currCounter].W_round48_L--;
#endif
        return result;
    }

    public static cmplx CL_negate(cmplx x)
    {
        cmplx result;
        result.re = L_negate(x.re);
        result.im = L_negate(x.im);
#if (WMOPS)
        multiCounter[currCounter].CL_negate++;
        multiCounter[currCounter].L_negate--;
        multiCounter[currCounter].L_negate--;
#endif
        return result;
    }

    public static cmplx CL_conjugate(cmplx x)
    {
        cmplx result;
        result.re = x.re;
        result.im = L_negate(x.im);
#if (WMOPS)
        multiCounter[currCounter].CL_conjugate++;
        multiCounter[currCounter].L_negate--;
#endif
        return result;
    }


    public static cmplx CL_mul_j(cmplx input)
    {
        cmplx temp, result;
        temp = CL_negate(input);
        result.re = temp.im;
        result.im = input.re;
#if (WMOPS)
        multiCounter[currCounter].CL_mul_j++;
        multiCounter[currCounter].CL_negate--;
#endif
        return result;
    }

    public static cmplx CL_swap_real_imag(cmplx input)
    {
        cmplx result;
        result.re = input.im;
        result.im = input.re;
#if (WMOPS)
        multiCounter[currCounter].CL_swap_real_imag++;
#endif
        return result;
    }

    public static cmplx_s C_add(cmplx_s inp1, cmplx_s inp2)
    {
        cmplx_s @out;
        @out.re = add(inp1.re, inp2.re);
        @out.im = add(inp1.im, inp2.im);

#if (WMOPS)
        multiCounter[currCounter].C_add++;
        multiCounter[currCounter].add--;
        multiCounter[currCounter].add--;
#endif
        return @out;
    }

    public static cmplx_s C_sub(cmplx_s inp1, cmplx_s inp2)
    {
        cmplx_s @out;
        @out.re = sub(inp1.re, inp2.re);
        @out.im = sub(inp1.im, inp2.im);

#if (WMOPS)
        multiCounter[currCounter].C_sub++;
        multiCounter[currCounter].sub--;
        multiCounter[currCounter].sub--;
#endif
        return @out;
    }

    public static cmplx_s C_mul_j(cmplx_s input)
    {
        cmplx_s result;
        Word16 temp;
        temp = negate(input.im);
        result.re = temp;
        result.im = input.re;

#if (WMOPS)
        multiCounter[currCounter].C_mul_j++;
        multiCounter[currCounter].negate--;
#endif
        return result;
    }

    public static cmplx_s C_multr(cmplx_s x, cmplx_s c)
    {
        cmplx_s result;
        result.re = round_fx(W_sat_l(W_sub_nosat(W_mult_16_16(x.re, c.re), W_mult_16_16(x.im, c.im))));
        result.im = round_fx(W_sat_l(W_add_nosat(W_mult_16_16(x.im, c.re), W_mult_16_16(x.re, c.im))));

#if (WMOPS)
        multiCounter[currCounter].C_multr++;
        multiCounter[currCounter].W_mult_16_16--;
        multiCounter[currCounter].W_mult_16_16--;
        multiCounter[currCounter].W_mult_16_16--;
        multiCounter[currCounter].W_mult_16_16--;
        multiCounter[currCounter].W_sub_nosat--;
        multiCounter[currCounter].W_add_nosat--;
        multiCounter[currCounter].W_sat_l--;
        multiCounter[currCounter].W_sat_l--;
        multiCounter[currCounter].round--;
        multiCounter[currCounter].round--;
#endif
        return result;
    }

    public static cmplx_s C_form(Word16 re, Word16 im)
    {
        cmplx_s result;
        result.re = re;
        result.im = im;
#if (WMOPS)
        multiCounter[currCounter].C_form++;
#endif
        return result;
    }

    public static cmplx C_scale(cmplx_s x, Word16 y)
    {
        cmplx result;
        result.re = L_mult(x.re, y);
        result.im = L_mult(x.im, y);
#if (WMOPS)
        multiCounter[currCounter].L_mult--;
        multiCounter[currCounter].L_mult--;
        multiCounter[currCounter].C_scale++;
#endif
        return (result);
    }

    public static cmplx_s CL_round32_16(cmplx x)
    {
        cmplx_s result;
        result.re = round_fx(x.re);
        result.im = round_fx(x.im);

#if (WMOPS)
        multiCounter[currCounter].CL_round32_16++;
        multiCounter[currCounter].round--;
        multiCounter[currCounter].round--;
#endif
        return result;
    }

    public static cmplx CL_scale_32(cmplx x, Word32 y)
    {
        cmplx result;
        result.re = Mpy_32_32_r(x.re, y);
        result.im = Mpy_32_32_r(x.im, y);
#if (WMOPS)
        multiCounter[currCounter].Mpy_32_32_r--;
        multiCounter[currCounter].Mpy_32_32_r--;
        multiCounter[currCounter].CL_scale_32++;
#endif
        return (result);
    }

    public static cmplx CL_dscale_32(cmplx x, Word32 y1, Word32 y2)
    {
        cmplx result;
        result.re = Mpy_32_32_r(x.re, y1);
        result.im = Mpy_32_32_r(x.im, y2);
#if (WMOPS)
        multiCounter[currCounter].Mpy_32_32_r--;
        multiCounter[currCounter].Mpy_32_32_r--;
        multiCounter[currCounter].CL_dscale_32++;
#endif
        return (result);
    }

    public static cmplx CL_multr_32x32(cmplx x, cmplx y)
    {
        cmplx result;
        result.re = W_round64_L(W_sub(W_mult_32_32(x.re, y.re), W_mult_32_32(x.im, y.im)));
        result.im = W_round64_L(W_add(W_mult_32_32(x.im, y.re), W_mult_32_32(x.re, y.im)));

#if (WMOPS)
        multiCounter[currCounter].CL_multr_32x32++;
        multiCounter[currCounter].W_mult_32_32--;
        multiCounter[currCounter].W_mult_32_32--;
        multiCounter[currCounter].W_mult_32_32--;
        multiCounter[currCounter].W_mult_32_32--;
        multiCounter[currCounter].W_round64_L--;
        multiCounter[currCounter].W_round64_L--;
        multiCounter[currCounter].W_sub--;
        multiCounter[currCounter].W_add--;
#endif
        return result;
    }

    public static cmplx_s C_mac_r(cmplx x, cmplx_s y, Word16 c)
    {
        cmplx_s result;
        cmplx temp = CL_add(x, C_scale(y, c));
        result = CL_round32_16(temp);

#if (WMOPS)
        multiCounter[currCounter].C_mac_r++;
        multiCounter[currCounter].CL_add--;
        multiCounter[currCounter].C_scale--;
        multiCounter[currCounter].CL_round32_16--;
#endif
        return result;
    }

    public static cmplx_s C_msu_r(cmplx x, cmplx_s y, Word16 c)
    {
        cmplx_s result;
        cmplx temp = CL_sub(x, C_scale(y, c));
        result = CL_round32_16(temp);

#if (WMOPS)
        multiCounter[currCounter].C_msu_r++;
        multiCounter[currCounter].CL_sub--;
        multiCounter[currCounter].C_scale--;
        multiCounter[currCounter].CL_round32_16--;
#endif
        return result;
    }

    public static Word16 C_Extract_real(cmplx_s x)
    {
#if (WMOPS)
        multiCounter[currCounter].C_Extract_real++;
#endif
        return x.re;
    }

    public static Word16 C_Extract_imag(cmplx_s x)
    {
#if (WMOPS)
        multiCounter[currCounter].C_Extract_imag++;
#endif
        return x.im;
    }

    public static cmplx_s C_negate(cmplx_s x)
    {
        cmplx_s result;
        result.re = negate(x.re);
        result.im = negate(x.im);
#if (WMOPS)
        multiCounter[currCounter].C_negate++;
        multiCounter[currCounter].negate--;
        multiCounter[currCounter].negate--;
#endif
        return result;
    }

    public static cmplx_s C_conjugate(cmplx_s x)
    {
        cmplx_s result;
        result.re = x.re;
        result.im = negate(x.im);
#if (WMOPS)
        multiCounter[currCounter].C_conjugate++;
        multiCounter[currCounter].negate--;
#endif
        return result;
    }

    public static cmplx_s C_shr(cmplx_s inp, Word16 shift_val)
    {
        cmplx_s @out;
        @out.re = shr(inp.re, shift_val);
        @out.im = shr(inp.im, shift_val);
#if (WMOPS)
        multiCounter[currCounter].C_shr++;
        multiCounter[currCounter].shr--;
        multiCounter[currCounter].shr--;
#endif
        return @out;
    }

    public static cmplx_s C_shl(cmplx_s inp, Word16 shift_val)
    {
        cmplx_s @out;
        @out.re = shl(inp.re, shift_val);
        @out.im = shl(inp.im, shift_val);
#if (WMOPS)
        multiCounter[currCounter].C_shl++;
        multiCounter[currCounter].shl--;
        multiCounter[currCounter].shl--;
#endif
        return @out;
    }

    public static Flag LT_16(Word16 var1, Word16 var2)
    {
        Flag F_ret = 0;

        if (var1 < var2)
        {
            F_ret = 1;
        }
#if (WMOPS)
        multiCounter[currCounter].LT_16++;
#endif
        return F_ret;
    }

    public static Flag GT_16(Word16 var1, Word16 var2)
    {
        Flag F_ret = 0;

        if (var1 > var2)
        {
            F_ret = 1;
        }
#if (WMOPS)
        multiCounter[currCounter].GT_16++;
#endif
        return F_ret;
    }

    public static Flag LE_16(Word16 var1, Word16 var2)
    {
        Flag F_ret = 0;

        if (var1 <= var2)
        {
            F_ret = 1;
        }
#if (WMOPS)
        multiCounter[currCounter].LE_16++;
#endif
        return F_ret;
    }

    public static Flag GE_16(Word16 var1, Word16 var2)
    {
        Flag F_ret = 0;

        if (var1 >= var2)
        {
            F_ret = 1;
        }
#if (WMOPS)
        multiCounter[currCounter].GE_16++;
#endif
        return F_ret;
    }

    public static Flag EQ_16(Word16 var1, Word16 var2)
    {
        Flag F_ret = 0;

        if (var1 == var2)
        {
            F_ret = 1;
        }
#if (WMOPS)
        multiCounter[currCounter].EQ_16++;
#endif
        return F_ret;
    }

    public static Flag NE_16(Word16 var1, Word16 var2)
    {
        Flag F_ret = 0;

        if (var1 != var2)
        {
            F_ret = 1;
        }
#if (WMOPS)
        multiCounter[currCounter].NE_16++;
#endif
        return F_ret;
    }

    public static Flag LT_32(Word32 L_var1, Word32 L_var2)
    {
        Flag F_ret = 0;

        if (L_var1 < L_var2)
        {
            F_ret = 1;
        }
#if (WMOPS)
        multiCounter[currCounter].LT_32++;
#endif
        return F_ret;
    }

    public static Flag GT_32(Word32 L_var1, Word32 L_var2)
    {
        Flag F_ret = 0;

        if (L_var1 > L_var2)
        {
            F_ret = 1;
        }
#if (WMOPS)
        multiCounter[currCounter].GT_32++;
#endif
        return F_ret;
    }

    public static Flag LE_32(Word32 L_var1, Word32 L_var2)
    {
        Flag F_ret = 0;

        if (L_var1 <= L_var2)
        {
            F_ret = 1;
        }
#if (WMOPS)
        multiCounter[currCounter].LE_32++;
#endif
        return F_ret;
    }

    public static Flag GE_32(Word32 L_var1, Word32 L_var2)
    {
        Flag F_ret = 0;

        if (L_var1 >= L_var2)
        {
            F_ret = 1;
        }
#if (WMOPS)
        multiCounter[currCounter].GE_32++;
#endif
        return F_ret;
    }

    public static Flag EQ_32(Word32 L_var1, Word32 L_var2)
    {
        Flag F_ret = 0;

        if (L_var1 == L_var2)
        {
            F_ret = 1;
        }
#if (WMOPS)
        multiCounter[currCounter].EQ_32++;
#endif
        return F_ret;
    }

    public static Flag NE_32(Word32 L_var1, Word32 L_var2)
    {
        Flag F_ret = 0;

        if (L_var1 != L_var2)
        {
            F_ret = 1;
        }
#if (WMOPS)
        multiCounter[currCounter].NE_32++;
#endif
        return F_ret;
    }

    public static Flag LT_64(Word64 L64_var1, Word64 L64_var2)
    {
        Flag F_ret = 0;

        if (L64_var1 < L64_var2)
        {
            F_ret = 1;
        }
#if (WMOPS)
        multiCounter[currCounter].LT_64++;
#endif
        return F_ret;
    }

    public static Flag GT_64(Word64 L64_var1, Word64 L64_var2)
    {
        Flag F_ret = 0;

        if (L64_var1 > L64_var2)
        {
            F_ret = 1;
        }
#if (WMOPS)
        multiCounter[currCounter].GT_64++;
#endif
        return F_ret;
    }

    public static Flag LE_64(Word64 L64_var1, Word64 L64_var2)
    {
        Flag F_ret = 0;

        if (L64_var1 <= L64_var2)
        {
            F_ret = 1;
        }
#if (WMOPS)
        multiCounter[currCounter].LE_64++;
#endif
        return F_ret;
    }
    public static Flag GE_64(Word64 L64_var1, Word64 L64_var2)
    {
        Flag F_ret = 0;

        if (L64_var1 >= L64_var2)
        {
            F_ret = 1;
        }
#if (WMOPS)
        multiCounter[currCounter].GE_64++;
#endif
        return F_ret;
    }

    public static Flag EQ_64(Word64 L64_var1, Word64 L64_var2)
    {
        Flag F_ret = 0;

        if (L64_var1 == L64_var2)
        {
            F_ret = 1;
        }
#if (WMOPS)
        multiCounter[currCounter].EQ_64++;
#endif
        return F_ret;
    }
    public static Flag NE_64(Word64 L64_var1, Word64 L64_var2)
    {
        Flag F_ret = 0;

        if (L64_var1 != L64_var2)
        {
            F_ret = 1;
        }
#if (WMOPS)
        multiCounter[currCounter].NE_64++;
#endif
        return F_ret;
    }

    public static Word32 Mpy_32_16_1(Word32 L_var1, Word16 var2)
    {
        Word32 L_var_out = W_sat_m(W_mult_32_16(L_var1, var2));
#if (WMOPS)
        multiCounter[currCounter].Mpy_32_16_1++;
        multiCounter[currCounter].W_mult_32_16--;
        multiCounter[currCounter].W_sat_m--;
#endif
        return L_var_out;
    }

    public static Word32 Mpy_32_16_r(Word32 L_var1, Word16 var2)
    {
        Word32 L_var_out = W_round48_L(W_mult_32_16(L_var1, var2));
#if (WMOPS)
        multiCounter[currCounter].Mpy_32_16_r++;
        multiCounter[currCounter].W_mult_32_16--;
        multiCounter[currCounter].W_round48_L--;
#endif
        return L_var_out;
    }

    public static Word32 Mpy_32_32(Word32 L_var1, Word32 L_var2)
    {
        Word32 L_var_out;
        Word64 L64_var1;

        L64_var1 = ((Word64)L_var1 * L_var2);
        L64_var1 = W_shl(L64_var1, 1);
        L_var_out = W_extract_h(L64_var1);
#if (WMOPS)
        multiCounter[currCounter].Mpy_32_32++;
        multiCounter[currCounter].W_shl--;
        multiCounter[currCounter].W_extract_h--;
#endif
        return L_var_out;
    }

    public static Word32 Mpy_32_32_r(Word32 L_var1, Word32 L_var2)
    {
        Word32 L_var_out;
        Word64 L64_var1;

        L64_var1 = ((Word64)L_var1 * L_var2);
        L64_var1 = W_shr(L64_var1, 15);
        L_var_out = W_round48_L(L64_var1);
#if (WMOPS)
        multiCounter[currCounter].Mpy_32_32_r++;
        multiCounter[currCounter].W_shr--;
        multiCounter[currCounter].W_round48_L--;
#endif
        return L_var_out;
    }

    public static Word32 Madd_32_16(Word32 L_var3, Word32 L_var1, Word16 var2)
    {
        Word32 L_var_out;

        L_var_out = Mpy_32_16_1(L_var1, var2);
        L_var_out = L_add(L_var3, L_var_out);

#if (WMOPS)
        multiCounter[currCounter].Mpy_32_16_1--;
        multiCounter[currCounter].L_add--;
        multiCounter[currCounter].Madd_32_16++;
#endif
        return L_var_out;
    }

    public static Word32 Madd_32_16_r(Word32 L_var3, Word32 L_var1, Word16 var2)
    {
        Word32 L_var_out;

        L_var_out = Mpy_32_16_r(L_var1, var2);
        L_var_out = L_add(L_var3, L_var_out);

#if (WMOPS)
        multiCounter[currCounter].Mpy_32_16_r--;
        multiCounter[currCounter].L_add--;
        multiCounter[currCounter].Madd_32_16_r++;
#endif
        return L_var_out;
    }

    public static Word32 Msub_32_16(Word32 L_var3, Word32 L_var1, Word16 var2)
    {
        Word32 L_var_out;

        L_var_out = Mpy_32_16_1(L_var1, var2);
        L_var_out = L_sub(L_var3, L_var_out);

#if (WMOPS)
        multiCounter[currCounter].Mpy_32_16_1--;
        multiCounter[currCounter].L_sub--;
        multiCounter[currCounter].Msub_32_16++;
#endif
        return L_var_out;
    }

    public static Word32 Msub_32_16_r(Word32 L_var3, Word32 L_var1, Word16 var2)
    {
        Word32 L_var_out;

        L_var_out = Mpy_32_16_r(L_var1, var2);
        L_var_out = L_sub(L_var3, L_var_out);

#if (WMOPS)
        multiCounter[currCounter].Mpy_32_16_r--;
        multiCounter[currCounter].L_sub--;
        multiCounter[currCounter].Msub_32_16_r++;
#endif
        return L_var_out;
    }

    public static Word32 Madd_32_32(Word32 L_var3, Word32 L_var1, Word32 L_var2)
    {
        Word32 L_var_out;

        L_var_out = Mpy_32_32(L_var1, L_var2);
        L_var_out = L_add(L_var3, L_var_out);

#if (WMOPS)
        multiCounter[currCounter].Mpy_32_32--;
        multiCounter[currCounter].L_add--;
        multiCounter[currCounter].Madd_32_32++;
#endif
        return L_var_out;
    }

    public static Word32 Madd_32_32_r(Word32 L_var3, Word32 L_var1, Word32 L_var2)
    {
        Word32 L_var_out;

        L_var_out = Mpy_32_32_r(L_var1, L_var2);
        L_var_out = L_add(L_var3, L_var_out);

#if (WMOPS)
        multiCounter[currCounter].Mpy_32_32_r--;
        multiCounter[currCounter].L_add--;
        multiCounter[currCounter].Madd_32_32_r++;
#endif
        return L_var_out;
    }

    public static Word32 Msub_32_32(Word32 L_var3, Word32 L_var1, Word32 L_var2)
    {
        Word32 L_var_out;

        L_var_out = Mpy_32_32(L_var1, L_var2);
        L_var_out = L_sub(L_var3, L_var_out);

#if (WMOPS)
        multiCounter[currCounter].Mpy_32_32--;
        multiCounter[currCounter].L_sub--;
        multiCounter[currCounter].Msub_32_32++;
#endif
        return L_var_out;
    }

    public static Word32 Msub_32_32_r(Word32 L_var3, Word32 L_var1, Word32 L_var2)
    {
        Word32 L_var_out;

        L_var_out = Mpy_32_32_r(L_var1, L_var2);
        L_var_out = L_sub(L_var3, L_var_out);

#if (WMOPS)
        multiCounter[currCounter].Mpy_32_32_r--;
        multiCounter[currCounter].L_sub--;
        multiCounter[currCounter].Msub_32_32_r++;
#endif
        return L_var_out;
    }

    /*****************************************************************************
 *
 *  Function Name : L40_set
 *
 *  Purpose :
 *
 *    Assigns a 40 constant to a Word40 with adequate initialization depending
 *    on underlying architecture constraints (for example to keep consistency
 *    of sign bits). Current implementation only validated on MSVC++6.0.
 *
 *  Complexity weight : 3
 *
 *  Inputs :
 *
 *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
 *                range : MIN_40 <= L40_var1 <= MAX_40.
 *
 *  Outputs :
 *
 *    none
 *
 *  Return Value :
 *
 *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
 *                the range : MIN_40 <= L40_var_out <= MAX_40.
 *
 *****************************************************************************/
    /*#ifdef _MSC_VER*/
    public static Word40 L40_set(Word40 L40_var1)
    {
        Word40 L40_var_out;

        L40_var_out = L40_var1 & 0x000000ffffffffff;

        if ((L40_var1 & 0x8000000000) != 0)
            L40_var_out = L40_var_out | unchecked((Word40)0xffffff0000000000);

#if WMOPS
        multiCounter[currCounter].L40_set++;
#endif

        return (L40_var_out);
    }

    // #endif /* ifdef _MSC_VER */



    /*****************************************************************************
     *
     *  Function Name : Extract40_H
     *
     *  Purpose :
     *
     *    Returns the bits [31-16] of L40_var1.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    var_out     16 bit short unsigned integer (UWord16) whose value falls in
     *                the range : MIN_U_16 <= var_out <= MAX_U_16.
     *
     *****************************************************************************/
    public static UWord16 Extract40_H(Word40 L40_var1)
    {
        UWord16 var_out;

        var_out = (UWord16)(L40_var1 >> 16);

#if (WMOPS)
        multiCounter[currCounter].Extract40_H++;
#endif

        return (var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : Extract40_L
     *
     *  Purpose :
     *
     *    Returns the bits [15-0] of L40_var1.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    var_out     16 bit short unsigned integer (UWord16) whose value falls in
     *                the range : MIN_U_16 <= var_out <= MAX_U_16.
     *
     *****************************************************************************/
    public static UWord16 Extract40_L(Word40 L40_var1)
    {
        UWord16 var_out;

        var_out = (UWord16)(L40_var1);

#if (WMOPS)
        multiCounter[currCounter].Extract40_L++;
#endif

        return (var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L_Extract40
     *
     *  Purpose :
     *
     *    Returns the bits [31-0] of L40_var1.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L_var_out   32 bit long unsigned integer (UWord32) whose value falls in
     *                range : MIN_U_32 <= L_var_out <= MAX_U_32.
     *
     *****************************************************************************/
    public static UWord32 L_Extract40(Word40 L40_var1)
    {
        UWord32 L_var_out;

        L_var_out = (UWord32)L40_var1;

#if (WMOPS)
        multiCounter[currCounter].L_Extract40++;
#endif

        return (L_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L40_deposit_h
     *
     *  Purpose :
     *
     *    Deposits var1 in the bits [31-16] in a 40-bit number. The 16 LSBits of
     *    the output are zeroed and the 8 MSBits sign extend var1 sign bit.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    var1        16 bit short signed integer (Word16) whose value falls in
     *                the range : MIN_16 <= var1 <= MAX_16.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : MIN_40 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    public static Word40 L40_deposit_h(Word16 var1)
    {
        Word40 L40_var_out;

        L40_var_out = ((Word40)var1) << 16;

        if ((var1 & 0x8000) != 0)
        {
            L40_var_out = L40_set(L40_var_out | 0xff00000000);

#if (WMOPS)
            multiCounter[currCounter].L40_set--;
#endif
        }
#if (WMOPS)
        multiCounter[currCounter].L40_deposit_h++;
#endif

        return (L40_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L40_deposit_l
     *
     *  Purpose :
     *
     *    Deposits var1 in the bits [15-0] in a 40-bit number. The 24 MSBits sign
     *    extend var1 sign bit.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    var1        16 bit short signed integer (Word16) whose value falls in
     *                the range : MIN_16 <= var1 <= MAX_16.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : MIN_40 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    public static Word40 L40_deposit_l(Word16 var1)
    {
        Word40 L40_var_out;

        L40_var_out = var1;

        if ((var1 & 0x8000) != 0)
        {
            L40_var_out = L40_set(L40_var_out | 0xffffff0000);

#if (WMOPS)
            multiCounter[currCounter].L40_set--;
#endif
        }
#if (WMOPS)
        multiCounter[currCounter].L40_deposit_l++;
#endif

        return (L40_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L40_deposit32
     *
     *  Purpose :
     *
     *    Deposits L_var1 in the bits [31-0] in a 40-bit number. The 8 MSBits sign
     *    extend L_var1 sign bit.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L_var1      32 bit long signed integer (Word32) whose value falls in the
     *                range : 0x8000 0000 <= L_var1 <= 0x7fff ffff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : MIN_40 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    public static Word40 L40_deposit32(Word32 L_var1)
    {
        Word40 L40_var_out;

        L40_var_out = (Word40)L_var1;

        if ((L_var1 & 0x80000000) != 0)
        {
            L40_var_out = L40_set(L40_var_out | 0xff00000000);

#if (WMOPS)
            multiCounter[currCounter].L40_set--;
#endif
        }
#if (WMOPS)
        multiCounter[currCounter].L40_deposit32++;
#endif

        return (L40_var_out);
    }








    /*****************************************************************************
     *
     *  Function Name : L40_round
     *
     *  Purpose :
     *
     *    Rounds the lower 16 bits of the 40 bit input number. Returns the 40 bit
     *    result with bits 15-0 cleared.
     *    Calls the macro L40_UNDERFLOW_OCCURED() in case of underflow on 40-bit.
     *    Calls the macro L40_OVERFLOW_OCCURED()  in case of overflow  on 40-bit.
     *
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : MIN_40 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    public static Word40 L40_round(Word40 L40_var1)
    {
        Word40 L40_var_out;
        Word40 L40_constant = L40_set(0xffffff0000);

        L40_var_out = L40_add(0x8000, L40_var1);
        L40_var_out = L40_var_out & L40_constant;

#if (WMOPS)
        multiCounter[currCounter].L40_set--;
        multiCounter[currCounter].L40_add--;
        multiCounter[currCounter].L40_round++;
#endif

        return (L40_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : round40
     *
     *  Purpose :
     *
     *    Rounds the lower 16 bits of the 40 bit input number. Saturates the 40
     *    bit result to 32-bit and returns the resulting higher 16-bit.
     *    round40( L40_var1) = extract_h( L_saturate40( L40_round( L40_var1)))
     *    Calls the macro L40_UNDERFLOW_OCCURED() in case of underflow on 40-bit.
     *    Calls the macro L40_OVERFLOW_OCCURED()  in case of overflow  on 40-bit.
     *
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    var_out     16 bit short signed integer (Word16) whose value falls in
     *                the range 0xffff 8000 <= var_out <= 0x0000 7fff.
     *
     *****************************************************************************/
    public static Word16 round40(Word40 L40_var1)
    {
        Word16 var_out;

        var_out = extract_h(L_saturate40(L40_round(L40_var1)));

#if (WMOPS)
        multiCounter[currCounter].L40_round--;
        multiCounter[currCounter].L_saturate40--;
        multiCounter[currCounter].extract_h--;
        multiCounter[currCounter].round40++;
#endif

        return (var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L40_mult
     *
     *  Purpose :
     *
     *    Multiplies var1 by var2 and shifts the result left by 1. Returns the
     *    full precision result on 40-bit.
     *    L40_mult( var1, var2) = shiftleft(( var1 times var2), 1)
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    var1        16 bit short signed integer (Word16) whose value falls in
     *                the range : MIN_16 <= var1 <= MAX_16.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in
     *                the range : MIN_16 <= var2 <= MAX_16.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : MIN_40 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    public static Word40 L40_mult(Word16 var1, Word16 var2)
    {
        Word32 L_var_out;
        Word40 L40_var_out;

        L_var_out = (Word32)var1 * (Word32)var2;
        L40_var_out = (Word40)L_var_out;

        /* Below line can not overflow, so we can use << instead of L40_shl. */
        L40_var_out = L40_var_out << 1;

#if (WMOPS)
        multiCounter[currCounter].L40_mult++;
#endif

        return (L40_var_out);
    }












    /*****************************************************************************
     *
     *  Function Name : L40_mac
     *
     *  Purpose :
     *
     *    Multiplies var2 by var3. Shifts left the 40-bit result by 1 and adds
     *    the result to L40_var1. Returns a 40 bit result.
     *    L40_mac( L40_var1, var2, var3)
     *    = L40_add( L40_var1, L40_mult( var2, var3))
     *    Calls the macro L40_UNDERFLOW_OCCURED() in case of underflow on 40-bit.
     *    Calls the macro L40_OVERFLOW_OCCURED()  in case of overflow  on 40-bit.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in
     *                the range : MIN_16 <= var2 <= MAX_16.
     *
     *    var3        16 bit short signed integer (Word16) whose value falls in
     *                the range : MIN_16 <= var3 <= MAX_16.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : MIN_40 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    public static Word40 L40_mac(Word40 L40_var1, Word16 var2, Word16 var3)
    {
        Word40 L40_var_out;

        L40_var_out = L40_mult(var2, var3);
        L40_var_out = L40_add(L40_var1, L40_var_out);

#if (WMOPS)
        multiCounter[currCounter].L40_mult--;
        multiCounter[currCounter].L40_add--;
        multiCounter[currCounter].L40_mac++;
#endif

        return (L40_var_out);
    }






    /*****************************************************************************
     *
     *  Function Name : mac_r40
     *
     *  Purpose :
     *
     *    Multiplies var2 by var3. Shifts left the 40-bit result by 1 and adds
     *    the result to L40_var1. Rounds the lower 16 bits of the 40 bit result.
     *    Saturates the 40 bit result to 32-bit and returns the resulting higher
     *    16-bit.
     *    mac_r40( L40_var1, var2, var3)
     *    = round40( L40_mac( L40_var1, var2, var3))
     *    Calls the macro L40_UNDERFLOW_OCCURED() in case of underflow on 40-bit.
     *    Calls the macro L40_OVERFLOW_OCCURED()  in case of overflow  on 40-bit.
     *
     *  Complexity weight : 2
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in
     *                the range : MIN_16 <= var2 <= MAX_16.
     *
     *    var3        16 bit short signed integer (Word16) whose value falls in
     *                the range : MIN_16 <= var3 <= MAX_16.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    var_out     16 bit short signed integer (Word16) whose value falls in
     *                the range : MIN_16 <= var_out <= MAX_16.
     *
     *****************************************************************************/
    public static Word16 mac_r40(Word40 L40_var1, Word16 var2, Word16 var3)
    {
        Word40 L40_var_out;
        Word16 var_out;

        L40_var_out = L40_mac(L40_var1, var2, var3);
        var_out = round40(L40_var_out);

#if (WMOPS)
        multiCounter[currCounter].L40_mac--;
        multiCounter[currCounter].round40--;
        multiCounter[currCounter].mac_r40++;
#endif

        return (var_out);
    }






    /*****************************************************************************
     *
     *  Function Name : L40_msu
     *
     *  Purpose :
     *
     *    Multiplies var2 by var3. Shifts left the 40-bit result by 1 and
     *    subtracts the result from L40_var1. Returns a 40 bit result.
     *    L40_msu( L40_var1, var2, var3)
     *    = L40_sub( L40_var1, L40_mult( var2, var3))
     *    Calls the macro L40_UNDERFLOW_OCCURED() in case of underflow on 40-bit.
     *    Calls the macro L40_OVERFLOW_OCCURED()  in case of overflow  on 40-bit.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in
     *                the range : MIN_16 <= var2 <= MAX_16.
     *
     *    var3        16 bit short signed integer (Word16) whose value falls in
     *                the range : MIN_16 <= var3 <= MAX_16.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : MIN_40 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    static Word40 L40_msu(Word40 L40_var1, Word16 var2, Word16 var3)
    {
        Word40 L40_var_out;

        L40_var_out = L40_mult(var2, var3);
        L40_var_out = L40_sub(L40_var1, L40_var_out);

#if (WMOPS)
        multiCounter[currCounter].L40_mult--;
        multiCounter[currCounter].L40_sub--;
        multiCounter[currCounter].L40_msu++;
#endif

        return (L40_var_out);
    }






    /*****************************************************************************
     *
     *  Function Name : msu_r40
     *
     *  Purpose :
     *
     *    Multiplies var2 by var3. Shifts left the 40-bit result by 1 and
     *    subtracts the result from L40_var1. Rounds the lower 16 bits of the
     *    40 bit result. Saturates the 40 bit result to 32-bit and returns the
     *    resulting higher 16-bit.
     *    msu_r40( L40_var1, var2, var3)
     *    = round40( L40_msu( L40_var1, var2, var3))
     *    Calls the macro L40_UNDERFLOW_OCCURED() in case of underflow on 40-bit.
     *    Calls the macro L40_OVERFLOW_OCCURED()  in case of overflow  on 40-bit.
     *
     *  Complexity weight : 2
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in
     *                the range : MIN_16 <= var2 <= MAX_16.
     *
     *    var3        16 bit short signed integer (Word16) whose value falls in
     *                the range : MIN_16 <= var3 <= MAX_16.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    var_out     16 bit short signed integer (Word16) whose value falls in
     *                the range : MIN_16 <= var_out <= MAX_16.
     *
     *****************************************************************************/
    public static Word16 msu_r40(Word40 L40_var1, Word16 var2, Word16 var3)
    {
        Word40 L40_var_out;
        Word16 var_out;

        L40_var_out = L40_msu(L40_var1, var2, var3);
        var_out = round40(L40_var_out);

#if (WMOPS)
        multiCounter[currCounter].L40_msu--;
        multiCounter[currCounter].round40--;
        multiCounter[currCounter].msu_r40++;
#endif

        return (var_out);
    }

    /*****************************************************************************
     *
     *  Function Name : L40_shl
     *
     *  Purpose :
     *
     *    Arithmetically shifts left L40_var1 by var2 positions.
     *    - If var2 is negative, L40_var1 is shifted to the LSBits by (-var2)
     *      positions with extension of the sign bit.
     *    - If var2 is positive, L40_var1 is shifted to the MSBits by (var2)
     *      positions.
     *    Calls the macro L40_UNDERFLOW_OCCURED() in case of underflow on 40-bit.
     *    Calls the macro L40_OVERFLOW_OCCURED()  in case of overflow  on 40-bit.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in
     *                the range : MIN_16 <= var2 <= MAX_16.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : MIN_40 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    public static Word40 L40_shl(Word40 L40_var1, Word16 var2)
    {

        Word40 L40_var_out;
        Word40 L40_constant = L40_set(0xc000000000);

        if (var2 < 0)
        {
            var2 = (Word16)(-var2);
            L40_var_out = L40_shr(L40_var1, var2);

#if (WMOPS)
            multiCounter[currCounter].L40_shr--;
#endif
        }

        else
        {
            L40_var_out = L40_var1;

            for (; var2 > 0; var2--)
            {
                if (L40_var_out > 0x003fffffffff)
                {
                    L40_var_out = L40_OVERFLOW_OCCURED(L40_var_out);
                    break;
                }

                else if (L40_var_out < L40_constant)
                {
                    L40_var_out = L40_UNDERFLOW_OCCURED(L40_var_out);
                    break;
                }

                else
                {
                    L40_var_out = L40_var_out << 1;
                }
            }
        }

#if (WMOPS)
        multiCounter[currCounter].L40_set--;
        multiCounter[currCounter].L40_shl++;
#endif

        return (L40_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L40_shr
     *
     *  Purpose :
     *
     *    Arithmetically shifts right L40_var1 by var2 positions.
     *    - If var2 is positive, L40_var1 is shifted to the LSBits by (var2)
     *      positions with extension of the sign bit.
     *    - If var2 is negative, L40_var1 is shifted to the MSBits by (-var2)
     *      positions.
     *    Calls the macro L40_UNDERFLOW_OCCURED() in case of underflow on 40-bit.
     *    Calls the macro L40_OVERFLOW_OCCURED()  in case of overflow  on 40-bit.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in
     *                the range : MIN_16 <= var2 <= MAX_16.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : MIN_40 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    public static Word40 L40_shr(Word40 L40_var1, Word16 var2)
    {
        Word40 L40_var_out;

        if (var2 < 0)
        {
            var2 = (Word16)(-var2);
            L40_var_out = L40_shl(L40_var1, var2);

#if (WMOPS)
            multiCounter[currCounter].L40_shl--;
#endif

        }
        else
        {
            L40_var_out = L40_var1 >> var2;
        }

#if (WMOPS)
        multiCounter[currCounter].L40_shr++;
#endif

        return (L40_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L40_negate
     *
     *  Purpose :
     *
     *    Negates L40_var1.
     *    Calls the macro L40_UNDERFLOW_OCCURED() in case of underflow on 40-bit.
     *    Calls the macro L40_OVERFLOW_OCCURED()  in case of overflow  on 40-bit.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : MIN_40 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    public static Word40 L40_negate(Word40 L40_var1)
    {
        Word40 L40_var_out;

        L40_var_out = L40_add(~L40_var1, 0x01);

#if (WMOPS)
        multiCounter[currCounter].L40_add--;
        multiCounter[currCounter].L40_negate++;
#endif

        return (L40_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L40_add
     *
     *  Purpose :
     *
     *    Adds L40_var1 and L40_var2 and returns the 40-bit result.
     *    Calls the macro L40_UNDERFLOW_OCCURED() in case of underflow on 40-bit.
     *    Calls the macro L40_OVERFLOW_OCCURED()  in case of overflow  on 40-bit.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *    L40_var2    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var2 <= MAX_40.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : MIN_40 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    public static Word40 L40_add(Word40 L40_var1, Word40 L40_var2)
    {
        Word40 L40_var_out;

        L40_var_out = L40_var1 + L40_var2;

        if ((((L40_var1 & 0x8000000000) >> 39) != 0)
            && (((L40_var2 & 0x8000000000) >> 39) != 0)
            && (((L40_var_out & 0x8000000000) >> 39) == 0))
        {
            L40_var_out = L40_UNDERFLOW_OCCURED(L40_var_out);

        }
        else if ((((L40_var1 & 0x8000000000) >> 39) == 0)
                   && (((L40_var2 & 0x8000000000) >> 39) == 0)
                   && (((L40_var_out & 0x8000000000) >> 39) != 0))
        {
            L40_var_out = L40_OVERFLOW_OCCURED(L40_var_out);
        }
#if (WMOPS)
        multiCounter[currCounter].L40_add++;
#endif

        return (L40_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L40_sub
     *
     *  Purpose :
     *
     *    Subtracts L40_var2 from L40_var1.
     *    Calls the macro L40_UNDERFLOW_OCCURED() in case of underflow on 40-bit.
     *    Calls the macro L40_OVERFLOW_OCCURED()  in case of overflow  on 40-bit.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *    L40_var2    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var2 <= MAX_40.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : MIN_40 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    public static Word40 L40_sub(Word40 L40_var1, Word40 L40_var2)
    {
        Word40 L40_var_out;

        L40_var_out = L40_var1 - L40_var2;

        if ((((L40_var1 & 0x8000000000) >> 39) != 0)
            && (((L40_var2 & 0x8000000000) >> 39) == 0)
            && (((L40_var_out & 0x8000000000) >> 39) == 0))
        {
            L40_var_out = L40_UNDERFLOW_OCCURED(L40_var_out);

        }
        else if ((((L40_var1 & 0x8000000000) >> 39) == 0)
                   && (((L40_var2 & 0x8000000000) >> 39) != 0)
                   && (((L40_var_out & 0x8000000000) >> 39) != 0))
        {
            L40_var_out = L40_OVERFLOW_OCCURED(L40_var_out);
        }
#if (WMOPS)
        multiCounter[currCounter].L40_sub++;
#endif

        return (L40_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L40_abs
     *
     *  Purpose :
     *
     *    Returns the absolute value of L40_var1.
     *    Calls the macro L40_UNDERFLOW_OCCURED() in case of underflow on 40-bit.
     *    Calls the macro L40_OVERFLOW_OCCURED()  in case of overflow  on 40-bit.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : 0x00 0000 0000 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    public static Word40 L40_abs(Word40 L40_var1)
    {
        Word40 L40_var_out;

        if (L40_var1 < 0)
        {
            L40_var_out = L40_negate(L40_var1);

#if (WMOPS)
            multiCounter[currCounter].L40_negate--;
#endif

        }
        else
        {
            L40_var_out = L40_var1;
        }

#if (WMOPS)
        multiCounter[currCounter].L40_abs++;
#endif

        return (L40_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L40_max
     *
     *  Purpose :
     *
     *    Compares L40_var1 and L40_var2 and returns the maximum value.
     *
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *    L40_var2    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var2 <= MAX_40.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : MIN_40 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    public static Word40 L40_max(Word40 L40_var1, Word40 L40_var2)
    {
        Word40 L40_var_out;

        if (L40_var1 < L40_var2)
            L40_var_out = L40_var2;
        else
            L40_var_out = L40_var1;

#if (WMOPS)
        multiCounter[currCounter].L40_max++;
#endif

        return (L40_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L40_min
     *
     *  Purpose :
     *
     *    Compares L40_var1 and L40_var2 and returns the minimum value.
     *
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *    L40_var2    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var2 <= MAX_40.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : MIN_40 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    public static Word40 L40_min(Word40 L40_var1, Word40 L40_var2)
    {
        Word40 L40_var_out;

        if (L40_var1 < L40_var2)
            L40_var_out = L40_var1;
        else
            L40_var_out = L40_var2;

#if (WMOPS)
        multiCounter[currCounter].L40_min++;
#endif

        return (L40_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L_saturate40
     *
     *  Purpose :
     *
     *    If L40_var1 is greater than MAX_32, returns MAX_32.
     *    If L40_var1 is lower   than MIN_32, returns MIN_32.
     *    If not,                             returns L_Extract40( L40_var1).
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L_var_out   32 bit long signed integer (Word32) whose value falls in
     *                the range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.
     *
     *****************************************************************************/
    public static Word32 L_saturate40(Word40 L40_var1)
    {
        Word32 L_var_out;

        Word40 UNDER_L40_var2 = (Word40)~((((Word40)1) << 31) - (Word40)1);
        Word40 OVER_L40_var2 = (Word40)((((Word40)1) << 31) - (Word40)1);

        if (L40_var1 < UNDER_L40_var2)
        {
            L40_var1 = UNDER_L40_var2;
            Overflow = 1;
        }

        if (L40_var1 > OVER_L40_var2)
        {
            L40_var1 = OVER_L40_var2;
            Overflow = 1;
        }

        L_var_out = (Word32)L_Extract40(L40_var1);

#if (WMOPS)
        multiCounter[currCounter].L_Extract40--;
        multiCounter[currCounter].L_saturate40++;
#endif

        return (L_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name :  Mpy_32_16_ss
     *
     *  Purpose :
     *
     *    Multiplies the 2 signed values L_var1 and var2 with saturation control
     *    on 48-bit. The operation is performed in fractional mode :
     *    - L_var1 is supposed to be in 1Q31 format.
     *    - var2   is supposed to be in 1Q15 format.
     *    - The result is produced in 1Q47 format : L_varout_h points to the
     *      32 MSBits while varout_l points to the 16 LSBits.
     *
     *  Complexity weight : 2
     *
     *  Inputs :
     *
     *    L_var1      32 bit long signed integer (Word32) whose value falls in
     *                the range : 0x8000 0000 <= L_var1 <= 0x7fff ffff.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in 
     *                the range : 0xffff 8000 <= var2 <= 0x0000 7fff.
     *
     *  Outputs :
     *
     *    *L_varout_h 32 bit long signed integer (Word32) whose value falls in
     *                the range : 0x8000 0000 <= L_varout_h <= 0x7fff ffff.
     *
     *    *varout_l   16 bit short unsigned integer (UWord16) whose value falls in
     *                the range : 0x0000 0000 <= varout_l <= 0x0000 ffff.
     *
     *  Return Value :
     *
     *    none
     *
     *****************************************************************************/
    public static void Mpy_32_16_ss(Word32 L_var1, Word16 var2, Word32* L_varout_h, UWord16* varout_l)
    {
        unchecked
        {

            Word16 var1_h;
            UWord16 uvar1_l;
            Word40 L40_var1;

            if ((L_var1 == (Word32)0x80000000)
                && (var2 == (Word16)0x8000))
            {
                *L_varout_h = 0x7fffffff;
                *varout_l = (UWord16)0xffff;

            }
            else
            {
                uvar1_l = (UWord16)extract_l(L_var1);
                var1_h = extract_h(L_var1);

                /* Below line can not overflow, so we can use << instead of L40_shl.  */
                L40_var1 = ((Word40)((Word32)var2 * (Word32)uvar1_l)) << 1;

                *varout_l = Extract40_L(L40_var1);

                L40_var1 = L40_shr(L40_var1, 16);
                L40_var1 = L40_mac(L40_var1, var2, var1_h);

                *L_varout_h = (Word32)L_Extract40(L40_var1);

#if (WMOPS)
                multiCounter[currCounter].extract_l--;
                multiCounter[currCounter].extract_h--;
                multiCounter[currCounter].Extract40_L--;
                multiCounter[currCounter].L40_shr--;
                multiCounter[currCounter].L40_mac--;
                multiCounter[currCounter].L_Extract40--;
#endif
            }

#if (WMOPS)
            multiCounter[currCounter].Mpy_32_16_ss++;
#endif

            return;
        }
    }


    /*****************************************************************************
     *
     *  Function Name :  Mpy_32_32_ss
     *
     *  Purpose :
     *
     *    Multiplies the 2 signed values L_var1 and L_var2 with saturation control
     *    on 64-bit. The operation is performed in fractional mode :
     *    - L_var1 and L_var2 are supposed to be in 1Q31 format.
     *    - The result is produced in 1Q63 format : L_varout_h points to the
     *      32 MSBits while L_varout_l points to the 32 LSBits.
     *
     *  Complexity weight : 4
     *
     *  Inputs :
     *
     *    L_var1      32 bit long signed integer (Word32) whose value falls in the
     *                range : 0x8000 0000  <= L_var1 <= 0x7fff ffff.
     *
     *    L_var2      32 bit long signed integer (Word32) whose value falls in the
     *                range : 0x8000 0000  <= L_var2 <= 0x7fff ffff.
     *
     *  Outputs :
     *
     *    *L_varout_h 32 bit long signed integer (Word32) whose value falls in
     *                the range : 0x8000 0000 <= L_varout_h <= 0x7fff ffff.
     *
     *    *L_varout_l 32 bit short unsigned integer (UWord32) whose value falls in
     *                the range : 0x0000 0000 <= L_varout_l <= 0xffff ffff.
     *
     *
     *  Return Value :
     *
     *    none
     *
     *****************************************************************************/
    public static void Mpy_32_32_ss(Word32 L_var1, Word32 L_var2, Word32* L_varout_h, UWord32* L_varout_l)
    {
        unchecked
        {
            UWord16 uvar1_l, uvar2_l;
            Word16 var1_h, var2_h;
            Word40 L40_var1;

            if ((L_var1 == (Word32)0x80000000) && (L_var2 == (Word32)0x80000000))
            {
                *L_varout_h = 0x7fffffff;
                *L_varout_l = (UWord32)0xffffffff;

            }
            else
            {

                uvar1_l = (UWord16)extract_l(L_var1);
                var1_h = extract_h(L_var1);
                uvar2_l = (UWord16)extract_l(L_var2);
                var2_h = extract_h(L_var2);

                /* Below line can not overflow, so we can use << instead of L40_shl.  */
                L40_var1 = ((Word40)((UWord32)uvar2_l * (UWord32)uvar1_l)) << 1;

                *L_varout_l = 0x0000ffff & L_Extract40(L40_var1);

                L40_var1 = L40_shr(L40_var1, 16);
                L40_var1 = L40_add(L40_var1, ((Word40)((Word32)var2_h * (Word32)uvar1_l)) << 1);
                L40_var1 = L40_add(L40_var1, ((Word40)((Word32)var1_h * (Word32)uvar2_l)) << 1);
                *L_varout_l |= (L_Extract40(L40_var1)) << 16;

                L40_var1 = L40_shr(L40_var1, 16);
                L40_var1 = L40_mac(L40_var1, var1_h, var2_h);

                *L_varout_h = (Word32)L_Extract40(L40_var1);

#if (WMOPS)
                multiCounter[currCounter].extract_l -= 2;
                multiCounter[currCounter].extract_h -= 2;
                multiCounter[currCounter].L_Extract40 -= 3;
                multiCounter[currCounter].L40_shr -= 2;
                multiCounter[currCounter].L40_add -= 2;
                multiCounter[currCounter].L40_mac--;
#endif
            }

#if (WMOPS)
            multiCounter[currCounter].Mpy_32_32_ss++;
#endif

            return;
        }
    }


    /*****************************************************************************
     *
     *  Function Name : L40_lshl
     *
     *  Purpose :
     *
     *    Logically shifts left L40_var1 by var2 positions.
     *    - If var2 is negative, L40_var1 is shifted to the LSBits by (-var2)
     *      positions with insertion of 0 at the MSBit.
     *    - If var2 is positive, L40_var1 is shifted to the MSBits by (var2)
     *      positions.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in
     *                the range : MIN_16 <= var2 <= MAX_16.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : MIN_40 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    public static Word40 L40_lshl(Word40 L40_var1, Word16 var2)
    {
        Word40 L40_var_out;

        if (var2 <= 0)
        {
            var2 = (Word16)(-var2);
            L40_var_out = L40_lshr(L40_var1, var2);

#if (WMOPS)
            multiCounter[currCounter].L40_lshr--;
#endif

        }
        else
        {
            if (var2 >= 40)
                L40_var_out = 0x0000000000;
            else
                L40_var_out = L40_var1 << var2;

            L40_var_out = L40_set(L40_var_out);

#if (WMOPS)
            multiCounter[currCounter].L40_set--;
#endif
        }

#if (WMOPS)
        multiCounter[currCounter].L40_lshl++;
#endif

        return (L40_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L40_lshr
     *
     *  Purpose :
     *
     *    Logically shifts right L40_var1 by var2 positions.
     *    - If var2 is positive, L40_var1 is shifted to the LSBits by (var2)
     *      positions with insertion of 0 at the MSBit.
     *    - If var2 is negative, L40_var1 is shifted to the MSBits by (-var2)
     *      positions.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in
     *                the range : MIN_16 <= var2 <= MAX_16.
    *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : MIN_40 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    public static Word40 L40_lshr(Word40 L40_var1, Word16 var2)
    {
        Word40 L40_var_out;

        if (var2 < 0)
        {
            var2 = (Word16)(-var2);
            L40_var_out = L40_lshl(L40_var1, var2);

#if (WMOPS)
            multiCounter[currCounter].L40_lshl--;
#endif
        }
        else
        {
            if (var2 >= 40)
                L40_var_out = 0x0000000000;
            else
                L40_var_out = (L40_var1 & 0xffffffffff) >> var2;
        }

#if (WMOPS)
        multiCounter[currCounter].L40_lshr++;
#endif

        return (L40_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : norm_L40
     *
     *  Purpose :
     *
     *    Produces the number of left shifts needed to normalize in 32 bit format
     *    the 40 bit variable L40_var1. This returned value can be used to scale
     *    L_40_var1 into the following intervals : 
     *    - [(MAX_32+1)/2 .. MAX_32       ] for positive values.
     *    - [ MIN_32      .. (MIN_32/2)+1 ] for negative values.
     *    - [ 0           .. 0            ] for null     values.
     *    In order to normalize the result, the following operation must be done :
     *    normelized_L40_var1 = L40_shl( L40_var1, norm_L40( L40_var1))
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    var_out     16 bit short signed integer (Word16) whose value falls in
     *                the range : -8 <= var_out <= 31.
     *
     *****************************************************************************/
    public static Word16 norm_L40(Word40 L40_var1)
    {
        unchecked
        {

            Word16 var_out;

            var_out = 0;

            if (L40_var1 != 0)
            {
                while ((L40_var1 > (Word32)0x80000000L)
                       && (L40_var1 < (Word32)0x7fffffffL))
                {

                    L40_var1 = L40_shl(L40_var1, 1);
                    var_out++;

#if WMOPS
                    multiCounter[currCounter].L40_shl--;
#endif
                }

                while ((L40_var1 < (Word32)0x80000000L)
                       || (L40_var1 > (Word32)0x7fffffffL))
                {

                    L40_var1 = L40_shl(L40_var1, -1);
                    var_out--;

#if WMOPS
                    multiCounter[currCounter].L40_shl--;
#endif
                }
            }
#if WMOPS
            multiCounter[currCounter].norm_L40++;
#endif

            return (var_out);
        }
    }






    /*****************************************************************************
     *
     *  Function Name : L40_shr_r
     *
     *  Purpose :
     *
     *    Arithmetically shifts right L40_var1 by var2 positions and rounds the
     *    result. It is equivalent to L40_shr( L40_var1, var2) except that if the
     *    last bit shifted out to the LSBit is 1, then the shifted result is
     *    incremented by 1.
     *    Calls the macro L40_UNDERFLOW_OCCURED() in case of underflow on 40-bit.
     *    Calls the macro L40_OVERFLOW_OCCURED()  in case of overflow  on 40-bit.
     *
     *  Complexity weight : 3
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in 
     *                the range : 0xffff 8000 <= var2 <= 0x0000 7fff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : MIN_40 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    public static Word40 L40_shr_r(Word40 L40_var1, Word16 var2)
    {
        Word40 L40_var_out;

        if (var2 > 39)
        {
            L40_var_out = 0;

        }
        else
        {
            L40_var_out = L40_shr(L40_var1, var2);

#if (WMOPS)
            multiCounter[currCounter].L40_shr--;
#endif

            if (var2 > 0)
            {
                if ((L40_var1 & ((Word40)1 << (var2 - 1))) != 0)
                {
                    /* below line can not generate overflows on 40-bit */
                    L40_var_out++;
                }
            }
        }

#if (WMOPS)
        multiCounter[currCounter].L40_shr_r++;
#endif

        return (L40_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L40_shl_r
     *
     *  Purpose :
     *
     *    Arithmetically shifts left L40_var1 by var2 positions and rounds the
     *    result. It is equivalent to L40_shl( L40_var1, var2) except if var2 is
     *    negative. In that case, it does the same as
     *    L40_shr_r( L40_var1, (-var2)).
     *    Calls the macro L40_UNDERFLOW_OCCURED() in case of underflow on 40-bit.
     *    Calls the macro L40_OVERFLOW_OCCURED()  in case of overflow  on 40-bit.
     *
     *  Complexity weight : 3
     *
     *  Inputs :
     *
     *    L40_var1    40 bit long signed integer (Word40) whose value falls in the
     *                range : MIN_40 <= L40_var1 <= MAX_40.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in 
     *                the range : 0xffff 8000 <= var2 <= 0x0000 7fff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L40_var_out 40 bit long signed integer (Word40) whose value falls in
     *                the range : MIN_40 <= L40_var_out <= MAX_40.
     *
     *****************************************************************************/
    public static Word40 L40_shl_r(Word40 L40_var1, Word16 var2)
    {
        Word40 L40_var_out;

        if (var2 >= 0)
        {
            L40_var_out = L40_shl(L40_var1, var2);

#if (WMOPS)
            multiCounter[currCounter].L40_shl--;
#endif

        }
        else
        {
            var2 = (Word16)(-var2);
            L40_var_out = L40_shr_r(L40_var1, var2);

#if (WMOPS)
            multiCounter[currCounter].L40_shr_r--;
#endif
        }
#if (WMOPS)
        multiCounter[currCounter].L40_shl_r++;
#endif

        return (L40_var_out);
    }

#if ENH_64_BIT_OPERATOR


    /*___________________________________________________________________________
    |                                                                           |
    |   Function Name : W_add_nosat                                           |
    |                                                                           |
    |   Purpose :                                                               |
    |                                                                           |
    |   64 bits addition of the two 64 bits variables (L64_var1+L64_var2)       |
    |                                                                           |
    |   Complexity weight : 1                                                   |
    |                                                                           |
    |   Inputs :                                                                |
    |                                                                           |
    |   L64_var1   64 bit long signed integer (Word64) whose value falls in the |
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL. |
    |                                                                           |
    |   L64_var2   64 bit long signed integer (Word64) whose value falls in the |
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL. |
    |                                                                           |
    |   Outputs :                                                               |
    |                                                                           |
    |    none                                                                   |
    |                                                                           |
    |   Return Value :                                                          |
    |                                                                           |
    |    L64_var_out                                                            |
    |             64 bit long signed integer (Word64) whose value falls in the  |
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL. |
    |___________________________________________________________________________|
    */
    public static Word64 W_add_nosat(Word64 L64_var1, Word64 L64_var2)
    {
        Word64 L64_var_out;

        L64_var_out = L64_var1 + L64_var2;

#if (WMOPS)
        multiCounter[currCounter].W_add_nosat++;
#endif

        return L64_var_out;
    }


    /*___________________________________________________________________________
    |                                                                           |
    |   Function Name : W_sub_nosat                                             |
    |                                                                           |
    |   Purpose :                                                               |
    |                                                                           |
    |   64 bits subtraction of the two 64 bits variables (L64_var1-L64_var2)    |
    |                                                                           |
    |   Complexity weight : 1                                                   |
    |                                                                           |
    |   Inputs :                                                                |
    |                                                                           |
    |   L64_var1   64 bit long signed integer (Word64) whose value falls in the |
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL. |
    |                                                                           |
    |   L64_var2   64 bit long signed integer (Word64) whose value falls in the |
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL. |
    |                                                                           |
    |   Outputs :                                                               |
    |                                                                           |
    |    none                                                                   |
    |                                                                           |
    |   Return Value :                                                          |
    |                                                                           |
    |    L64_var_out                                                            |
    |             64 bit long signed integer (Word64) whose value falls in the  |
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL. |
    |___________________________________________________________________________|
    */
    public static Word64 W_sub_nosat(Word64 L64_var1, Word64 L64_var2)
    {
        Word64 L64_var_out;

        L64_var_out = L64_var1 - L64_var2;

#if (WMOPS)
        multiCounter[currCounter].W_sub_nosat++;
#endif

        return L64_var_out;
    }


    /*___________________________________________________________________________
    |                                                                           |
    |   Function Name : W_shl                                                   |
    |                                                                           |
    |   Purpose :                                                               |
    |                                                                           |
    |   Arithmetically shift the 64 bit input L64_var1 left var2 positions. Zero|
    |   fill the var2 LSB of the result. If var2 is negative, arithmetically    |
    |   shift L64_var1 right by -var2 with sign extension. Saturate the result  |
    |   in case of underflows or overflows.                                     |
    |                                                                           |
    |   Complexity weight : 1                                                   |
    |                                                                           |
    |   Inputs :                                                                |
    |                                                                           |
    |    L64_var1   64 bit long signed integer (Word64) whose value falls in the|
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL. |
    |                                                                           |
    |    var2                                                                   |
    |             16 bit short signed integer (Word16) whose value falls in the |
    |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
    |                                                                           |
    |   Outputs :                                                               |
    |                                                                           |
    |    none                                                                   |
    |                                                                           |
    |   Return Value :                                                          |
    |                                                                           |
    |    L64_var_out                                                            |
    |             64 bit long signed integer (Word64) whose value falls in the  |
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL. |
    |___________________________________________________________________________|
    */
    public static Word64 W_shl(Word64 L64_var1, Word16 var2)
    {
        unchecked
        {

            Word64 L64_var_out = 0L;

            if (var2 <= 0)
            {
                if (var2 < -64)
                    var2 = -64;
                var2 = (Word16)(-var2);
                L64_var_out = L64_var1 >> var2;
            }
            else
            {
                for (; var2 > 0; var2--)
                {
                    if (L64_var1 > (Word64)0X3fffffffffffffffL)
                    {
                        Overflow = 1;
                        L64_var_out = (Word64)0X7fffffffffffffffL;
                        break;
                    }
                    else
                    {
                        if (L64_var1 < (Word64)0xc000000000000000L)
                        {
                            Overflow = 1;
                            L64_var_out = (Word64)0x8000000000000000L;
                            break;
                        }
                    }
                    L64_var1 *= 2;
                    L64_var_out = L64_var1;
                }
            }
#if (WMOPS)
            multiCounter[currCounter].W_shl++;
#endif

            //  BASOP_CHECK();

            return (L64_var_out);
        }
    }


    /*___________________________________________________________________________
    |                                                                           |
    |   Function Name : W_shr                                                   |
    |                                                                           |
    |   Purpose :                                                               |
    |                                                                           |
    |   Arithmetically shift the 64 bit input L64_var1 right var2 positions.    |
    |   Zero fill the var2 LSB of the result. If var2 is negative,              |
    |   arithmetically shift L64_var1 left by -var2 with sign extension.        |
    |   Saturate the result in case of underflows or overflows.                 |
    |                                                                           |
    |   Complexity weight : 1                                                   |
    |                                                                           |
    |   Inputs :                                                                |
    |                                                                           |
    |    L64_var1   64 bit long signed integer (Word64) whose value falls in the|
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL. |
    |                                                                           |
    |    var2                                                                   |
    |             16 bit short signed integer (Word16) whose value falls in the |
    |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
    |                                                                           |
    |   Outputs :                                                               |
    |                                                                           |
    |    none                                                                   |
    |                                                                           |
    |   Return Value :                                                          |
    |                                                                           |
    |    L64_var_out                                                            |
    |             64 bit long signed integer (Word64) whose value falls in the  |
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL. |
    |___________________________________________________________________________|
    */
    public static Word64 W_shr(Word64 L64_var1, Word16 var2)
    {
        Word64 L64_var_out;

        if (var2 < 0)
        {
            var2 = (Word16)(-var2);
            L64_var_out = W_shl(L64_var1, var2);

#if (WMOPS)
            multiCounter[currCounter].W_shl--;
#endif

        }
        else
        {
            L64_var_out = L64_var1 >> var2;
        }

#if (WMOPS)
        multiCounter[currCounter].W_shr++;
#endif

        return (L64_var_out);
    }


    /*___________________________________________________________________________
    |                                                                           |
    |   Function Name : W_shl_nosat                                             |
    |                                                                           |
    |   Purpose :                                                               |
    |                                                                           |
    | Arithmetically shifts left the 64-bit variable W_var1 by var2 positions.  |
    |  if var2 is negative, W_var1 is shifted to the least significant bits by  | 
    |  (�var2) positions with extension of the sign bit .                       |
    |  if var2 is positive, W_var1 is shifted to the most significant bits by   | 
    |   (var2) positions without saturation control on 64 bits.                 |
    |                                                                           |
    |   Complexity weight : 1                                                   |
    |                                                                           |
    |   Inputs :                                                                |
    |                                                                           |
    |    L64_var1   64 bit long signed integer (Word64) whose value falls in the|
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL. |
    |                                                                           |
    |    var2                                                                   |
    |             16 bit short signed integer (Word16) whose value falls in the |
    |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
    |                                                                           |
    |   Outputs :                                                               |
    |                                                                           |
    |    none                                                                   |
    |                                                                           |
    |   Return Value :                                                          |
    |                                                                           |
    |    L64_var_out                                                            |
    |             64 bit long signed integer (Word64) whose value falls in the  |
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL. |
    |___________________________________________________________________________|
    */
    public static Word64 W_shl_nosat(Word64 L64_var1, Word16 var2)
    {

        Word64 L64_var_out = 0L;

        if (var2 <= 0)
        {
            var2 = (Word16)(-var2);
            L64_var_out = L64_var1 >> var2;
        }
        else
        {
            L64_var_out = L64_var1 << var2;
        }
#if (WMOPS)
        multiCounter[currCounter].W_shl_nosat++;
#endif

        //  BASOP_CHECK ();

        return (L64_var_out);
    }


    /*___________________________________________________________________________
    |                                                                           |
    |   Function Name : W_shr_nosat                                             |
    |                                                                           |
    |   Purpose :                                                               |
    |                                                                           |
    | Arithmetically shifts right the 64-bit variable W_var1 by var2 positions. |
    |  if var2 is negative, W_var1 is shifted to the most significant bits by   | 
    |  (�var2) positions without saturation control on 64 bits.                 |
    |  if var2 is positive, W_var1 is shifted to the least significant bits by  | 
    |   (var2) positions with extension of the sign bit .                       |
    |                                                                           |
    |   Complexity weight : 1                                                   |
    |                                                                           |
    |   Inputs :                                                                |
    |                                                                           |
    |    L64_var1   64 bit long signed integer (Word64) whose value falls in the|
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL. |
    |                                                                           |
    |    var2                                                                   |
    |             16 bit short signed integer (Word16) whose value falls in the |
    |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                   |
    |                                                                           |
    |   Outputs :                                                               |
    |                                                                           |
    |    none                                                                   |
    |                                                                           |
    |   Return Value :                                                          |
    |                                                                           |
    |    L64_var_out                                                            |
    |             64 bit long signed integer (Word64) whose value falls in the  |
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL. |
    |___________________________________________________________________________|
    */
    public static Word64 W_shr_nosat(Word64 L64_var1, Word16 var2)
    {
        Word64 L64_var_out;

        if (var2 < 0)
        {
            var2 = (Word16)(-var2);
            L64_var_out = L64_var1 << var2;

        }
        else
        {
            L64_var_out = L64_var1 >> var2;
        }

#if (WMOPS)
        multiCounter[currCounter].W_shr_nosat++;
#endif

        return (L64_var_out);
    }


    /*_________________________________________________________________________________________________
    |                                                                                                 |
    |   Function Name : W_mac_32_16                                                                   |
    |                                                                                                 |
    |   Purpose :                                                                                     |
    |                                                                                                 |
    |   Multiply L_var2 by var3 and shift the result left by 1. Add the 64 bit                        |
    |   result to L64_var1, return a 64 bit result.                                                   |
    |                                                                                                 |
    |   Complexity weight : 1                                                                         |
    |                                                                                                 |
    |   Inputs :                                                                                      |
    |                                                                                                 |
    |    L64_var1                                                                                     |
    |             64 bit long long signed integer (Word64) whose value falls in the                   |
    |             range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.                 |
    |                                                                                                 |
    |    L_var2                                                                                       |
    |             32 bit signed integer (Word32) whose value falls in the                             |
    |             range : 0x8000 0000 <= L_var2 <= 0x7fff ffff                                        |
    |                                                                                                 |
    |    var3                                                                                         |
    |             16 bit short signed integer (Word16) whose value falls in the                       |
    |             range : 0xffff 8000 <= var3 <= 0x0000 7fff.                                         |
    |                                                                                                 |
    |   Outputs :                                                                                     |
    |                                                                                                 |
    |    none                                                                                         |
    |                                                                                                 |
    |   Return Value :                                                                                |
    |                                                                                                 |
    |    L64_var_out                                                                                  |
    |             64 bit long long signed integer (Word64) whose value falls in the                   |
    |             range : 0x80000000 00000000LL <= L64_var_out <= 0x7fffffff ffffffffLL.              |
    |_________________________________________________________________________________________________|
    */
    public static Word64 W_mac_32_16(Word64 L64_var1, Word32 L_var2, Word16 var3)
    {
        Word64 L64_var_out = ((Word64)L_var2 * var3) << 1;
        L64_var_out += L64_var1;
#if (WMOPS)
        multiCounter[currCounter].W_mac_32_16++;
#endif 
        return L64_var_out;
    }


    /*_________________________________________________________________________________________________
    |                                                                                                 |
    |   Function Name : W_msu_32_16                                                                   |
    |                                                                                                 |
    |   Purpose :                                                                                     |
    |                                                                                                 |
    |   Multiply L_var2 by var3 and shift the result left by 1. Subtract the 64 bit                   |
    |   result from L64_var1, return a 64 bit result.                                                 |
    |                                                                                                 |
    |   Complexity weight : 1                                                                         |
    |                                                                                                 |
    |   Inputs :                                                                                      |
    |                                                                                                 |
    |    L64_var1                                                                                     |
    |             64 bit long long signed integer (Word64) whose value falls in the                   |
    |             range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.                 |
    |                                                                                                 |
    |    L_var2                                                                                       |
    |             32 bit signed integer (Word32) whose value falls in the                             |
    |             range : 0x8000 0000 <= L_var2 <= 0x7fff ffff                                        |
    |                                                                                                 |
    |    var3                                                                                         |
    |             16 bit short signed integer (Word16) whose value falls in the                       |
    |             range : 0xffff 8000 <= var3 <= 0x0000 7fff.                                         |
    |                                                                                                 |
    |   Outputs :                                                                                     |
    |                                                                                                 |
    |    none                                                                                         |
    |                                                                                                 |
    |   Return Value :                                                                                |
    |                                                                                                 |
    |    L64_var_out                                                                                  |
    |             64 bit long long signed integer (Word64) whose value falls in the                   |
    |             range : 0x80000000 00000000LL <= L64_var_out <= 0x7fffffff ffffffffLL.              |
    |_________________________________________________________________________________________________|
    */
    public static Word64 W_msu_32_16(Word64 L64_var1, Word32 L_var2, Word16 var3)
    {
        Word64 L64_var_out = ((Word64)L_var2 * var3) << 1;
        L64_var_out = L64_var1 - L64_var_out;
#if (WMOPS)
        multiCounter[currCounter].W_msu_32_16++;
#endif
        return L64_var_out;
    }


    /*_________________________________________________________________________________________________
    |                                                                                                 |
    |   Function Name : W_mult_32_16                                                             |
    |                                                                                                 |
    |   Purpose :                                                                                     |
    |                                                                                                 |
    |   Multiply L_var1 by var2 and shift the result left by 1. Return a 64 bit result.               |
    |                                                                                                 |
    |   Complexity weight : 1                                                                         |
    |                                                                                                 |
    |   Inputs :                                                                                      |
    |                                                                                                 |
    |    L_var1                                                                                       |
    |             32 bit signed integer (Word32) whose value falls in the                             |
    |             range : 0x8000 0000 <= L_var1 <= 0x7fff ffff                                        |
    |                                                                                                 |
    |    var2                                                                                         |
    |             16 bit short signed integer (Word16) whose value falls in the                       |
    |             range : 0xffff 8000 <= var2 <= 0x0000 7fff.                                         |
    |                                                                                                 |
    |   Outputs :                                                                                     |
    |                                                                                                 |
    |    none                                                                                         |
    |                                                                                                 |
    |   Return Value :                                                                                |
    |                                                                                                 |
    |    L64_var_out                                                                                  |
    |             64 bit long long signed integer (Word64) whose value falls in the                   |
    |             range : 0x80000000 00000000LL <= L64_var_out <= 0x7fffffff ffffffffLL.              |
    |_________________________________________________________________________________________________|
    */
    public static Word64 W_mult_32_16(Word32 L_var1, Word16 var2)
    {
        Word64 L64_var_out = ((Word64)L_var1 * var2) << 1;
#if (WMOPS)
        multiCounter[currCounter].W_mult_32_16++;
#endif
        return L64_var_out;
    }

    /*________________________________________________________________________________________________
    |                                                                                                 |
    |   Function Name : W_mult0_16_16                                                            |
    |                                                                                                 |
    |   Purpose :                                                                                     |
    |                                                                                                 |
    |   Multiply var1 by var2 and return a 64 bit result.                                             |
    |                                                                                                 |
    |   Complexity weight : 1                                                                         |
    |                                                                                                 |
    |   Inputs :                                                                                      |
    |                                                                                                 |
    |    var1                                                                                         |
    |             16 bit short signed integer (Word16) whose value falls in the                       |
    |             range : 0x8000 0000 <= L_var1 <= 0x7fff ffff                                        |
    |                                                                                                 |
    |    var2                                                                                         |
    |             16 bit short signed integer (Word16) whose value falls in the                       |
    |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                                         |
    |                                                                                                 |
    |   Outputs :                                                                                     |
    |                                                                                                 |
    |    none                                                                                         |
    |                                                                                                 |
    |   Return Value :                                                                                |
    |                                                                                                 |
    |    L64_var_out                                                                                  |
    |             64 bit long long signed integer (Word64) whose value falls in the                   |
    |             range : 0x80000000 00000000LL <= L64_acc <= 0x7fffffff ffffffffLL.                  |
    |_________________________________________________________________________________________________|
    */
    public static Word64 W_mult0_16_16(Word16 var1, Word16 var2)
    {
        Word64 L64_var_out = (Word64)var1 * var2;
#if (WMOPS)
        multiCounter[currCounter].W_mult0_16_16++;
#endif
        return L64_var_out;
    }

    /*________________________________________________________________________________________________
    |                                                                                                 |
    |   Function Name : W_mac0_16_16                                                                  |
    |                                                                                                 |
    |   Purpose :                                                                                     |
    |                                                                                                 |
    |   Multiply var2 by var3 and add the 64 bit result to L64_var1, return a 64 bit result.          |
    |                                                                                                 |
    |   Complexity weight : 1                                                                         |
    |                                                                                                 |
    |   Inputs :                                                                                      |
    |                                                                                                 |
    |    L64_var1                                                                                     |
    |             64 bit long long signed integer (Word64) whose value falls in the                   |
    |             range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.                 |
    |                                                                                                 |
    |    var2                                                                                         |
    |             16 bit short signed integer (Word16) whose value falls in the                       |
    |             range : 0xffff 8000 <= var2 <= 0x0000 7fff.                                         |
    |                                                                                                 |
    |    var3                                                                                         |
    |             16 bit short signed integer (Word16) whose value falls in the                       |
    |             range : 0xffff 8000 <= var3 <= 0x0000 7fff.                                         |
    |                                                                                                 |
    |   Outputs :                                                                                     |
    |                                                                                                 |
    |    none                                                                                         |
    |                                                                                                 |
    |   Return Value :                                                                                |
    |                                                                                                 |
    |    L64_var_out                                                                                  |
    |             64 bit long long signed integer (Word64) whose value falls in the                   |
    |             range : 0x80000000 00000000LL <= L64_var_out <= 0x7fffffff ffffffffLL.              |
    |_________________________________________________________________________________________________|
    */
    public static Word64 W_mac0_16_16(Word64 L64_var1, Word16 var2, Word16 var3)
    {
        Word64 L64_var_out = (Word64)var2 * var3;
        L64_var_out += L64_var1;
#if (WMOPS)
        multiCounter[currCounter].W_mac0_16_16++;
#endif
        return L64_var_out;
    }


    /*________________________________________________________________________________________________
    |                                                                                                 |
    |   Function Name : W_msu0_16_16                                                                  |
    |                                                                                                 |
    |   Purpose :                                                                                     |
    |                                                                                                 |
    |   Multiply var2 by var3 and subtract the 64 bit result from L64_var1, return a 64 bit result.   |
    |                                                                                                 |
    |   Complexity weight : 1                                                                         |
    |                                                                                                 |
    |   Inputs :                                                                                      |
    |                                                                                                 |
    |    L64_var1                                                                                     |
    |             64 bit long long signed integer (Word64) whose value falls in the                   |
    |             range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.                 |
    |                                                                                                 |
    |    var2                                                                                         |
    |             16 bit short signed integer (Word16) whose value falls in the                       |
    |             range : 0xffff 8000 <= var2 <= 0x0000 7fff.                                         |
    |                                                                                                 |
    |    var3                                                                                         |
    |             16 bit short signed integer (Word16) whose value falls in the                       |
    |             range : 0xffff 8000 <= var3 <= 0x0000 7fff.                                         |
    |                                                                                                 |
    |   Outputs :                                                                                     |
    |                                                                                                 |
    |    none                                                                                         |
    |                                                                                                 |
    |   Return Value :                                                                                |
    |                                                                                                 |
    |    L64_var_out                                                                                  |
    |             64 bit long long signed integer (Word64) whose value falls in the                   |
    |             range : 0x80000000 00000000LL <= L64_var_out <= 0x7fffffff ffffffffLL.              |
    |_________________________________________________________________________________________________|
    */
    public static Word64 W_msu0_16_16(Word64 L64_var1, Word16 var2, Word16 var3)
    {
        Word64 L64_var_out = (Word64)var2 * var3;
        L64_var_out = L64_var1 - L64_var_out;
#if (WMOPS)
        multiCounter[currCounter].W_msu0_16_16++;
#endif
        return L64_var_out;
    }



    /*_____________________________________________________________________________________
    |                                                                                     |
    |   Function Name : W_sat_l                                                           | 
    |                                                                                     |
    |   Purpose :                                                                         |
    |                                                                                     |
    |   Saturate the lower 32 bits of the 64 bit input number L64_var into 32 bits.       |
    |                                                                                     |
    |   Complexity weight : 1                                                             |
    |                                                                                     |
    |   Inputs :                                                                          |
    |                                                                                     |
    |    L64_var                                                                          |
    |             64 bit long long signed integer (Word64) whose value falls in the      |
    |             range : 0x80000000 00000000LL <= L64_var <= 0x7fffffff ffffffffLL.      |
    |                                                                                     |
    |   Outputs :                                                                         |
    |                                                                                     |
    |    none                                                                             |
    |                                                                                     |
    |   Return Value :                                                                    |
    |                                                                                     |
    |    L_var_out                                                                        |
    |             32 bit signed integer (Word32) whose value falls in the                 |
    |             range : 0x8000 0000 <= L_var_out <= 0x7fff 0000.                        |
    |_____________________________________________________________________________________|
    */
    public static Word32 W_sat_l(Word64 L64_var)
    {
        unchecked
        {

            Word32 L_var_out;

            if (L64_var > 0x7FFFFFFF)
            {
                L_var_out = 0x7FFFFFFF;
            }
            else if (L64_var < (int)0x80000000)
            {
                L_var_out = (Word32)0x80000000;
            }
            else
            {
                L_var_out = (Word32)L64_var;
            }

#if (WMOPS)
            multiCounter[currCounter].W_sat_l++;
#endif

            return L_var_out;
        }
    }



    /*___________________________________________________________________________________
    |                                                                                     |
    |   Function Name : W_sat_m                                                           | 
    |                                                                                     |
    |   Purpose :                                                                         |
    |                                                                                     |
    |   Truncates the lower 16 bits of the 64 bit input L64_var                           |
    |   and saturates the number into 32 bits.                                            |
    |                                                                                     |
    |   Complexity weight : 1                                                             |
    |                                                                                     |
    |   Inputs :                                                                          |
    |                                                                                     |
    |    L64_var                                                                          |
    |             64 bit long long signed integer (Word64) whose value falls in the      |
    |             range : 0x80000000 00000000LL <= L64_var <= 0x7fffffff ffffffffLL.      |
    |                                                                                     |
    |   Outputs :                                                                         |
    |                                                                                     |
    |    none                                                                             |
    |                                                                                     |
    |   Return Value :                                                                    |
    |                                                                                     |
    |    L_var_out                                                                        |
    |             32 bit signed integer (Word32) whose value falls in the                 |
    |             range : 0x8000 0000 <= L_var_out <= 0x7fff 0000.                        |
    |_____________________________________________________________________________________|
    */
    public static Word32 W_sat_m(Word64 L64_var)
    {
        Word32 L_var_out;

        L64_var = L64_var >> 16;
        L_var_out = W_sat_l(L64_var);

#if (WMOPS)
        multiCounter[currCounter].W_sat_l--;
        multiCounter[currCounter].W_sat_m++;
#endif

        return L_var_out;
    }


    /*__________________________________________________________________________________
    |                                                                                  |
    |   Function Name : W_deposit32_l                                                    |
    |                                                                                  |
    |   Purpose :                                                                      |
    |                                                                                  |
    |   Deposit the 32 bit L_var1 into the 32 LS bits of the 64 bit output. The        |
    |   32 MS bits of the output are sign extended.                                    |
    |                                                                                  |
    |   Complexity weight : 1                                                          |
    |                                                                                  |
    |   Inputs :                                                                       |
    |                                                                                  |
    |    L_var1                                                                        |
    |             32 bit long signed integer (Word32) whose value falls in the         |
    |             range : 0x8000 0000 <= var_out <= 0x7fff 0000.                       |                                                                           |
    |   Outputs :                                                                      |
    |                                                                                  |
    |    none                                                                          |
    |                                                                                  |
    |   Return Value :                                                                 |
    |                                                                                  |
    |    L64_var_out                                                                   |
    |             64 bit long long signed integer (Word64) whose value falls in        |
    |             range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.  |
    |__________________________________________________________________________________|
    */
    public static Word64 W_deposit32_l(Word32 L_var1)
    {
        Word64 L64_var_out;

        L64_var_out = (Word64)L_var1;

#if (WMOPS)
        multiCounter[currCounter].W_deposit32_l++;
#endif

        return (L64_var_out);
    }


    /*__________________________________________________________________________________
    |                                                                                  |
    |   Function Name : W_deposit32_h                                                    |
    |                                                                                  |
    |   Purpose :                                                                      |
    |                                                                                  |
    |   Deposit the 32 bit L_var1 into the 32 MS bits of the 64 bit output. The        |
    |   32 LS bits of the output are zeroed.                                           |
    |                                                                                  |
    |   Complexity weight : 1                                                          |
    |                                                                                  |
    |   Inputs :                                                                       |
    |                                                                                  |
    |    L_var1                                                                        |
    |             32 bit long signed integer (Word32) whose value falls in the         |
    |             range : 0x8000 0000 <= var_out <= 0x7fff 0000.                       |                                                                           |
    |   Outputs :                                                                      |
    |                                                                                  |
    |    none                                                                          |
    |                                                                                  |
    |   Return Value :                                                                 |
    |                                                                                  |
    |    L64_var_out                                                                   |
    |             64 bit long long signed integer (Word64) whose value falls in        |
    |             range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.  |
    |__________________________________________________________________________________|
    */
    public static Word64 W_deposit32_h(Word32 L_var1)
    {
        Word64 L64_var_out;

        L64_var_out = (Word64)L_var1 << 32;

#if (WMOPS)
        multiCounter[currCounter].W_deposit32_h++;
#endif

        return (L64_var_out);
    }


    /*__________________________________________________________________________________
    |                                                                                  |
    |   Function Name : W_extract_l                                                    |
    |                                                                                  |
    |   Purpose :                                                                      |
    |                                                                                  |
    |   Return the 32 LSB of L64_var1.                                                 |
    |                                                                                  |
    |   Complexity weight : 1                                                          |
    |                                                                                  |
    |   Inputs :                                                                       |
    |                                                                                  |
    |    L64_var1                                                                      |
    |             64 bit long long signed integer (Word64) whose value falls in        |
    |             range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.  |
    |                                                                                  |
    |   Outputs :                                                                      |
    |                                                                                  |
    |    none                                                                          |
    |                                                                                  |
    |   Return Value :                                                                 |
    |                                                                                  |
    |    L_var_out                                                                     |
    |             32 bit long signed integer (Word32) whose value falls in the         |
    |             range : 0x8000 0000 <= L_var_out <= 0x7fff 0000.                     |
    |__________________________________________________________________________________|
    */
    public static Word32 W_extract_l(Word64 L64_var1)
    {
        Word32 L_var_out;

        L_var_out = (Word32)L64_var1;

#if (WMOPS)
        multiCounter[currCounter].W_extract_l++;
#endif

        return (L_var_out);
    }



    /*__________________________________________________________________________________
    |                                                                                  |
    |   Function Name : W_extract_h                                                    |
    |                                                                                  |
    |   Purpose :                                                                      |
    |                                                                                  |
    |   Return the 32 MSB of L64_var1.                                                 |
    |                                                                                  |
    |   Complexity weight : 1                                                          |
    |                                                                                  |
    |   Inputs :                                                                       |
    |                                                                                  |
    |    L64_var1                                                                      |
    |             64 bit long long signed integer (Word64) whose value falls in        |
    |             range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.  |
    |                                                                                  |
    |   Outputs :                                                                      |
    |                                                                                  |
    |    none                                                                          |
    |                                                                                  |
    |   Return Value :                                                                 |
    |                                                                                  |
    |    L_var_out                                                                     |
    |             32 bit long signed integer (Word32) whose value falls in the         |
    |             range : 0x8000 0000 <= L_var_out <= 0x7fff 0000.                     |
    |__________________________________________________________________________________|
    */
    public static Word32 W_extract_h(Word64 L64_var1)
    {
        Word32 L_var_out;

        L_var_out = (Word32)(L64_var1 >> 32);

#if (WMOPS)
        multiCounter[currCounter].W_extract_h++;
#endif

        return (L_var_out);
    }



    /*________________________________________________________________________________________________
    |                                                                                                 |
    |   Function Name : W_mult_16_16                                                                  |
    |                                                                                                 |
    |   Purpose :                                                                                     |
    |                                                                                                 |
    |   Multiply var1 by var2 and shift the result left by 1. Return a 64 bit result.                 |
    |                                                                                                 |
    |   Complexity weight : 1                                                                         |
    |                                                                                                 |
    |   Inputs :                                                                                      |
    |                                                                                                 |
    |    var1                                                                                         |
    |             16 bit short signed integer (Word16) whose value falls in the                       |
    |             range : 0x8000 0000 <= L_var1 <= 0x7fff ffff                                        |
    |                                                                                                 |
    |    var2                                                                                         |
    |             16 bit short signed integer (Word16) whose value falls in the                       |
    |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                                         |
    |                                                                                                 |
    |   Outputs :                                                                                     |
    |                                                                                                 |
    |    none                                                                                         |
    |                                                                                                 |
    |   Return Value :                                                                                |
    |                                                                                                 |
    |    L64_var_out                                                                                  |
    |             64 bit long long signed integer (Word64) whose value falls in the                   |
    |             range : 0x80000000 00000000LL <= L64_acc <= 0x7fffffff ffffffffLL.                  |
    |_________________________________________________________________________________________________|
    */
    public static Word64 W_mult_16_16(Word16 var1, Word16 var2)
    {
        Word64 L64_var_out = ((Word64)var1 * var2) << 1;
#if (WMOPS)
        multiCounter[currCounter].W_mult_16_16++;
#endif
        return L64_var_out;
    }
    /*________________________________________________________________________________________________
    |                                                                                                 |
    |   Function Name : W_mac_16_16                                                                   |
    |                                                                                                 |
    |   Purpose :                                                                                     |
    |                                                                                                 |
    |   Multiply var1 by var2 and shift the result left by 1 and add the 64 bit result to L64_acc,    |
    |   return a 64 bit result.                                                                       |
    |                                                                                                 |
    |   Complexity weight : 1                                                                         |
    |                                                                                                 |
    |   Inputs :                                                                                      |
    |                                                                                                 |
    |    L64_acc                                                                                      |
    |             64 bit long long signed integer (Word64) whose value falls in the                   |
    |             range : 0x80000000 00000000LL <= L64_acc <= 0x7fffffff ffffffffLL.                  |
    |                                                                                                 |
    |    var1                                                                                         |
    |             16 bit short signed integer (Word16) whose value falls in the                       |
    |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                                         |
    |                                                                                                 |
    |    var2                                                                                         |
    |             16 bit short signed integer (Word16) whose value falls in the                       |
    |             range : 0xffff 8000 <= var2 <= 0x0000 7fff.                                         |
    |                                                                                                 |
    |   Outputs :                                                                                     |
    |                                                                                                 |
    |    none                                                                                         |
    |                                                                                                 |
    |   Return Value :                                                                                |
    |                                                                                                 |
    |    L64_var_out                                                                                  |
    |             64 bit long long signed integer (Word64) whose value falls in the                   |
    |             range : 0x80000000 00000000LL <= L64_var_out <= 0x7fffffff ffffffffLL.              |
    |_________________________________________________________________________________________________|
    */
    public static Word64 W_mac_16_16(Word64 L64_acc, Word16 var1, Word16 var2)
    {
        Word64 L64_var_out = ((Word64)var1 * var2) << 1;
        L64_acc = L64_acc + L64_var_out;

#if (WMOPS)
        multiCounter[currCounter].W_mac_16_16++;
#endif
        return L64_acc;
    }



    /*________________________________________________________________________________________________
    |                                                                                                 |
    |   Function Name : W_msu_16_16                                                                   |
    |                                                                                                 |
    |   Purpose :                                                                                     |
    |                                                                                                 |
    |   Multiply var2 by var3 and shift the result left by1 and subtract the 64 bit result            |
    |   from L64_var1, return a 64 bit result.                                                        |
    |                                                                                                 |
    |   Complexity weight : 1                                                                         |
    |                                                                                                 |
    |   Inputs :                                                                                      |
    |                                                                                                 |
    |    L64_var1                                                                                     |
    |             64 bit long long signed integer (Word64) whose value falls in the                   |
    |             range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.                 |
    |                                                                                                 |
    |    var2                                                                                         |
    |             16 bit short signed integer (Word16) whose value falls in the                       |
    |             range : 0xffff 8000 <= var2 <= 0x0000 7fff.                                         |
    |                                                                                                 |
    |    var3                                                                                         |
    |             16 bit short signed integer (Word16) whose value falls in the                       |
    |             range : 0xffff 8000 <= var3 <= 0x0000 7fff.                                         |
    |                                                                                                 |
    |   Outputs :                                                                                     |
    |                                                                                                 |
    |    none                                                                                         |
    |                                                                                                 |
    |   Return Value :                                                                                |
    |                                                                                                 |
    |    L64_var_out                                                                                  |
    |             64 bit long long signed integer (Word64) whose value falls in the                   |
    |             range : 0x80000000 00000000LL <= L64_var_out <= 0x7fffffff ffffffffLL.              |
    |_________________________________________________________________________________________________|
    */
    public static Word64 W_msu_16_16(Word64 L64_var1, Word16 var2, Word16 var3)
    {
        Word64 L64_var_out = ((Word64)var2 * var3) << 1;
        L64_var_out = L64_var1 - L64_var_out;
#if (WMOPS)
        multiCounter[currCounter].W_msu_16_16++;
#endif
        return L64_var_out;
    }


    /*___________________________________________________________________________
    |                                                                           |
    |   Function Name : W_shl_sat_l                                             |
    |                                                                           |
    |   Purpose :                                                               |
    |                                                                           |
    |   Arithmetically shift the 64 bit input L64_var left by n positions with  | 
    |   lower 32 bit saturation and return the 32 LSB of 64 bit result          |
    |                                                                           |
    |   Complexity weight : 1                                                   |
    |                                                                           |
    |   Inputs :                                                                |
    |                                                                           |
    |    L64_var                                                                |
    |       64 bit long signed integer (Word64) whose value falls in the        |
    |       range : 0x80000000 00000000LL <= L64_var <= 0x7fffffff ffffffffLL.  |
    |                                                                           |
    |    n                                                                      |
    |             32 bit signed integer (Word32) whose value falls in the       |
    |             range : 0x8000 0000 <= n <= 0x7fff 0000.                      |
    |                                                                           |
    |   Outputs :                                                               |
    |                                                                           |
    |    none                                                                   |
    |                                                                           |
    |   Return Value :                                                          |
    |                                                                           |
    |    L_result                                                               |
    |             32 bit long signed integer (Word32) whose value falls in the  |
    |             range : 0x8000 0000 <= L_result <= 0x7fff 0000.               |
    |___________________________________________________________________________|
    */
    public static Word32 W_shl_sat_l(Word64 L64_var, Word32 n)
    {
        Word32 L_result;
        Word64 d_var_64;

        d_var_64 = W_shl(L64_var, (Word16)n);
        L_result = W_sat_l(d_var_64);

#if (WMOPS)
        multiCounter[currCounter].W_shl_sat_l++;
        multiCounter[currCounter].W_shl--;
        multiCounter[currCounter].W_sat_l--;
#endif

        return L_result;
    }


    /*__________________________________________________________________________________
    |                                                                                  |
    |   Function Name : W_round48_L                                                    |
    |                                                                                  |
    |   Purpose :                                                                      |
    |                                                                                  |
    |  Round asymmetrically lower 16 bits, and                                         | 
    |  saturate the 17.47-bit values to 1.31-bit values                                | 
    |   Complexity weight : 1                                                          |
    |                                                                                  |
    |   Inputs :                                                                       |
    |                                                                                  |
    |    L64_var1                                                                      |
    |             64 bit long long signed integer (Word64) whose value falls in        |
    |             range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.  |
    |                                                                                  |
    |   Outputs :                                                                      |
    |                                                                                  |
    |    none                                                                          |
    |                                                                                  |
    |   Return Value :                                                                 |
    |                                                                                  |
    |    L_var_out                                                                     |
    |             32 bit long signed integer (Word32) whose value falls in the         |
    |             range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.                     |
    |__________________________________________________________________________________|
    */
    public static Word32 W_round48_L(Word64 L64_var1)
    {
        unchecked
        {

            Word64 L64_var_out;
            Word32 L_result;

            Word64 L64_var2 = 0x80000000;
            Word64 L64_MIN = (Word64)0x8000000000000000L;
            Word64 L64_MAX = 0x7FFFFFFFFFFFFFFFL;

            L64_var1 = W_shl(L64_var1, 16);

            L64_var_out = L64_var1 + L64_var2;

            if (((L64_var1 ^ L64_var2) & L64_MIN) == 0)
            {
                if (((L64_var_out ^ L64_var1) & L64_MIN) != 0)
                {
                    L64_var_out = (L64_var1 < 0) ? L64_MIN : L64_MAX;
                    Overflow = 1;
                }
            }
            L_result = W_extract_h(L64_var_out);
#if (WMOPS)
            multiCounter[currCounter].W_round48_L++;
            multiCounter[currCounter].W_extract_h--;
            multiCounter[currCounter].W_shl--;
#endif

            return (L_result);
        }
    }

    /*__________________________________________________________________________________
    |                                                                                  |
    |   Function Name : W_round32_s                                                    |
    |                                                                                  |
    |   Purpose :                                                                      |
    |                                                                                  |
    |  Round asymmetrically lower 32 bits, and                                         | 
    |  saturate the 17.47-bit values to 1.15-bit values                                | 
    |   Complexity weight : 1                                                          |
    |                                                                                  |
    |   Inputs :                                                                       |
    |                                                                                  |
    |    L64_var1                                                                      |
    |             64 bit long long signed integer (Word64) whose value falls in        |
    |             range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.  |
    |                                                                                  |
    |   Outputs :                                                                      |
    |                                                                                  |
    |    none                                                                          |
    |                                                                                  |
    |   Return Value :                                                                 |
    |                                                                                  |
    |    var_out                                                                       |
    |             16 bit short signed integer (Word16) whose value falls in the        |
    |             range : 0xffff 8000 <= var_out <= 0x0000 7fff.                       |
    |__________________________________________________________________________________|
    */
    public static Word16 W_round32_s(Word64 L64_var1)
    {
        Word64 L64_var_out;
        Word32 L_var;
        Word16 var_out;


        Word64 L64_var2 = 0x800000000000L;
        Word64 L64_MIN = unchecked((Word64)0x8000000000000000L);
        Word64 L64_MAX = 0x7FFFFFFFFFFFFFFFL;

        L64_var1 = W_shl(L64_var1, 16);
        L64_var_out = L64_var1 + L64_var2;

        if (((L64_var1 ^ L64_var2) & L64_MIN) == 0)
        {
            if (((L64_var_out ^ L64_var1) & L64_MIN) != 0)
            {
                L64_var_out = (L64_var1 < 0) ? L64_MIN : L64_MAX;
                Overflow = 1;
            }
        }
        L_var = W_extract_h(L64_var_out);
        var_out = extract_h(L_var);
#if (WMOPS)
        multiCounter[currCounter].W_round32_s++;
        multiCounter[currCounter].W_extract_h--;
        multiCounter[currCounter].extract_h--;
        multiCounter[currCounter].W_shl--;
#endif

        return (var_out);
    }
    /*___________________________________________________________________________
    |                                                                           |
    |   Function Name : W_norm                                                  |
    |                                                                           |
    |   Purpose :                                                               |
    |                                                                           |
    |   Produces the number of left shifts needed to normalize the 64 bit varia-|
    |   ble L64_var1.
    |                                                                           |
    |   Complexity weight : 1                                                   |
    |                                                                           |
    |   Inputs :                                                                |
    |                                                                           |
    |  L64_var1                                                                 |
    |      64 bit long long signed integer (Word64) whose value falls in        |
    |      range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.  |
    |                                                                           |
    |   Outputs :                                                               |
    |                                                                           |
    |    none                                                                   |
    |                                                                           |
    |   Return Value :                                                          |
    |                                                                           |
    |    var_out                                                                |
    |             16 bit short signed integer (Word16) whose value falls in the |
    |             range : 0x0000 0000 <= var_out <= 0x0000 003f.                |
    |___________________________________________________________________________|
    */
    public static Word16 W_norm(Word64 L64_var1)
    {
        Word16 var_out;
        if (L64_var1 == 0)
        {
            var_out = 0;
        }
        else
        {
            if (L64_var1 == unchecked((Word64)0xffffffffffffffffL))
            {
                var_out = 63;
            }
            else
            {
                if (L64_var1 < 0)
                {
                    L64_var1 = ~L64_var1;
                }
                for (var_out = 0; L64_var1 < (Word64)0x4000000000000000L; var_out++)
                {
                    L64_var1 <<= 1;
                }
            }
        }
#if (WMOPS)
        multiCounter[currCounter].W_norm++;
#endif
        return (var_out);
    }



    /*______________________________________________________________________________
    |                                                                               |
    |   Function Name : W_add                                                       |
    |                                                                               |
    |   Purpose :                                                                   |
    |                                                                               |
    |   64 bits addition of the two 64 bits variables (L64_var1+L64_var2)  with     |
    |   overflow control and saturation; the result is set at 0x7fffffffffffffffLL  |
    |   when overflow occurs or at 0x8000000000000000LL when underflow occurs.      |
    |                                                                               |
    |   Complexity weight : 1                                                       |
    |                                                                               |
    |   Inputs :                                                                    |
    |                                                                               |
    |   L64_var1   64 bit long signed integer (Word64) whose value falls in the     |
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.     |
    |                                                                               |
    |   L64_var2   64 bit long signed integer (Word64) whose value falls in the     |
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.     |
    |                                                                               |
    |   Outputs :                                                                   |
    |                                                                               |
    |    none                                                                       |
    |                                                                               |
    |   Return Value :                                                              |
    |                                                                               |
    |    L64_var_out                                                                |
    |             64 bit long signed integer (Word64) whose value falls in the      |
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.     |
    |_______________________________________________________________________________|
    */
    public static Word64 W_add(Word64 L64_var1, Word64 L64_var2)
    {
        Word64 L64_var_out;

        L64_var_out = L64_var1 + L64_var2;

        if (((L64_var1 ^ L64_var2) & MIN_64) == 0)
        {
            if (((L64_var_out ^ L64_var1) & MIN_64) != 0)
            {
                L64_var_out = (L64_var1 < 0) ? MIN_64 : MAX_64;
                Overflow = 1;
            }
        }

#if (WMOPS)
        multiCounter[currCounter].W_add++;
#endif
        return L64_var_out;
    }

    /*______________________________________________________________________________
    |                                                                               |
    |   Function Name : W_sub                                                       |
    |                                                                               |
    |   Purpose :                                                                   |
    |                                                                               |
    |   64 bits subtraction of the two 64 bits variables (L64_var1-L64_var2)  with  |
    |   overflow control and saturation; the result is set at 0x7fffffffffffffffLL  |
    |   when overflow occurs or at 0x8000000000000000LL when underflow occurs.      |
    |                                                                               |
    |   Complexity weight : 1                                                       |
    |                                                                               |
    |   Inputs :                                                                    |
    |                                                                               |
    |   L64_var1   64 bit long signed integer (Word64) whose value falls in the     |
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.     |
    |                                                                               |
    |   L64_var2   64 bit long signed integer (Word64) whose value falls in the     |
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.     |
    |                                                                               |
    |   Outputs :                                                                   |
    |                                                                               |
    |    none                                                                       |
    |                                                                               |
    |   Return Value :                                                              |
    |                                                                               |
    |    L64_var_out                                                                |
    |             64 bit long signed integer (Word64) whose value falls in the      |
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.     |
    |_______________________________________________________________________________|
    */
    public static Word64 W_sub(Word64 L64_var1, Word64 L64_var2)
    {
        Word64 L64_var_out;

        L64_var_out = L64_var1 - L64_var2;

        if (((L64_var1 ^ L64_var2) & MIN_64) != 0)
        {
            if (((L64_var_out ^ L64_var1) & MIN_64) != 0)
            {
                L64_var_out = (L64_var1 < 0) ? MIN_64 : MAX_64;
                Overflow = 1;
            }
        }

#if (WMOPS)
        multiCounter[currCounter].W_add++;
#endif
        return L64_var_out;
    }


    /*______________________________________________________________________________
    |                                                                               |
    |   Function Name : W_neg                                                       |
    |                                                                               |
    |   Purpose :                                                                   |
    |                                                                               |
    |   Negate the 64 bit variable L64_var1 with overflow control and saturation;   |
    |   Saturate and set overflow in the case where input is 0x8000000000000000LL.  |
    |                                                                               |
    |   Complexity weight : 1                                                       |
    |                                                                               |
    |   Inputs :                                                                    |
    |                                                                               |
    |   L64_var1   64 bit long signed integer (Word64) whose value falls in the     |
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.     |
    |                                                                               |
    |   Outputs :                                                                   |
    |                                                                               |
    |    none                                                                       |
    |                                                                               |
    |   Return Value :                                                              |
    |                                                                               |
    |    L64_var_out                                                                |
    |             64 bit long signed integer (Word64) whose value falls in the      |
    |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.     |
    |_______________________________________________________________________________|
    */
    public static Word64 W_neg(Word64 L64_var1)
    {
        Word64 L64_var_out;

        if (L64_var1 == MIN_64)
        {
            L64_var_out = MAX_64;
            Overflow = 1;
        }
        else
        {
            L64_var_out = -L64_var1;
        }

#if (WMOPS)
        multiCounter[currCounter].W_neg++;
#endif

        return (L64_var_out);

    }


    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : W_abs                                                   |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |    Absolute value of L64_var1; Saturate in case where the input is        |
     |    0x8000000000000000LL                                                   |
     |                                                                           |
     |   Complexity weight : 1                                                   |
     |                                                                           |
     |   Inputs :                                                                |
     |                                                                           |
     |   L64_var1   64 bit long signed integer (Word64) whose value falls in the |
     |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL. |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |    none                                                                   |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |    L64_var_out                                                            |
     |             64 bit long signed integer (Word64) whose value falls in the  |
     |       range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL. |
     |___________________________________________________________________________|
    */
    public static Word64 W_abs(Word64 L64_var1)
    {
        Word64 L64_var_out;

        if (L64_var1 == MIN_64)
        {
            L64_var_out = MAX_64;
            Overflow = 1;
        }
        else
        {
            if (L64_var1 < 0)
            {
                L64_var_out = -L64_var1;
            }
            else
            {
                L64_var_out = L64_var1;
            }
        }

#if (WMOPS)
        multiCounter[currCounter].W_abs++;
#endif

        return (L64_var_out);
    }

    /*_________________________________________________________________________________________________
    |                                                                                                 |
    |   Function Name : W_mult_32_32                                                                  |
    |                                                                                                 |
    |   Purpose :                                                                                     |
    |                                                                                                 |
    |   Multiply L_var1 by L_var2 and shift the result left by 1.Saturate and set overflow in case    |
    |    where both inputs are 0x80000000 .  Return a 64 bit result.                                  |
    |                                                                                                 |
    |   Complexity weight : 1                                                                         |
    |                                                                                                 |
    |   Inputs :                                                                                      |
    |                                                                                                 |
    |    L_var1                                                                                       |
    |             32 bit signed integer (Word32) whose value falls in the                             |
    |             range : 0x8000 0000 <= L_var1 <= 0x7fff ffff                                        |
    |                                                                                                 |
    |    L_var2                                                                                       |
    |             32 bit signed integer (Word32) whose value falls in the                             |
    |             range : 0x8000 0000 <= L_var1 <= 0x7fff ffff                                        |
    |                                                                                                 |
    |   Outputs :                                                                                     |
    |                                                                                                 |
    |    none                                                                                         |
    |                                                                                                 |
    |   Return Value :                                                                                |
    |                                                                                                 |
    |    L64_var_out                                                                                  |
    |             64 bit long long signed integer (Word64) whose value falls in the                   |
    |             range : 0x80000000 00000000LL <= L64_var_out <= 0x7fffffff ffffffffLL.              |
    |_________________________________________________________________________________________________|
    */
    public static Word64 W_mult_32_32(Word32 L_var1, Word32 L_var2)
    {
        Word64 L64_var_out;

        if ((L_var1 == MIN_32) && (L_var2 == MIN_32))
        {
            L64_var_out = MAX_64;
            Overflow = 1;
        }
        else
        {
            L64_var_out = ((Word64)L_var1 * L_var2) << 1;
        }

#if (WMOPS)
        multiCounter[currCounter].W_mult_32_32++;
#endif 
        return L64_var_out;
    }

    /*_________________________________________________________________________________________________
    |                                                                                                 |
    |   Function Name : W_mult0_32_32                                                                 |
    |                                                                                                 |
    |   Purpose :                                                                                     |
    |                                                                                                 |
    |   Multiply L_var1 by L_var2.  Return a 64 bit result.                                           |
    |                                                                                                 |
    |   Complexity weight : 1                                                                         |
    |                                                                                                 |
    |   Inputs :                                                                                      |
    |                                                                                                 |
    |    L_var1                                                                                       |
    |             32 bit signed integer (Word32) whose value falls in the                             |
    |             range : 0x8000 0000 <= L_var1 <= 0x7fff ffff                                        |
    |                                                                                                 |
    |    L_var2                                                                                       |
    |             32 bit signed integer (Word32) whose value falls in the                             |
    |             range : 0x8000 0000 <= L_var1 <= 0x7fff ffff                                        |
    |                                                                                                 |
    |   Outputs :                                                                                     |
    |                                                                                                 |
    |    none                                                                                         |
    |                                                                                                 |
    |   Return Value :                                                                                |
    |                                                                                                 |
    |    L64_var_out                                                                                  |
    |             64 bit long long signed integer (Word64) whose value falls in the                   |
    |             range : 0x80000000 00000000LL <= L64_var_out <= 0x7fffffff ffffffffLL.              |
    |_________________________________________________________________________________________________|
    */
    public static Word64 W_mult0_32_32(Word32 L_var1, Word32 L_var2)
    {
        Word64 L64_var_out;

        L64_var_out = (Word64)L_var1 * L_var2;


#if (WMOPS)
        multiCounter[currCounter].W_mult0_32_32++;
#endif
        return L64_var_out;
    }


    /*_____________________________________________________________________________
    |                                                                              |
    |   Function Name : W_lshl                                                     |
    |                                                                              |
    |   Purpose :                                                                  |
    |                                                                              |
    |   Logically shift the 64 bit unsigned input L64_var1 left by var2 positions. | 
    |   Zero fill the var2 LSB of the result. If var2 is negative, logically shift |
    |   L64_var1 right by -var2 with zero fill in the MSB.                         |
    |                                                                              |
    |   Complexity weight : 1                                                      |
    |                                                                              |
    |   Inputs :                                                                   |
    |                                                                              |
    |    L64_var1  64 bit long unsigned signed integer (UWord64) whose value falls | 
    |    in the range : 0LL <= L64_var1 <= 0xffffffff ffffffffLL.                  |
    |                                                                              |
    |    var2                                                                      |
    |             16 bit short signed integer (Word16) whose value falls in the    |
    |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                      |
    |                                                                              |
    |   Outputs :                                                                  |
    |                                                                              |
    |    none                                                                      |
    |                                                                              |
    |   Return Value :                                                             |
    |                                                                              |
    |    L64_var_out                                                               |
    |             64 bit long unsigned signed integer (UWord64) whose value falls  | 
    |    in the range : 0LL <= L64_var1 <= 0xffffffff ffffffffLL.                  |
    |______________________________________________________________________________|
    */
    public static UWord64 W_lshl(UWord64 L64_var1, Word16 var2)
    {

        UWord64 L64_var_out = 0L;

        if (var2 < 0)
        {
            L64_var_out = L64_var1 >> (-var2);
        }
        else
        {
            L64_var_out = L64_var1 << var2;
        }
#if (WMOPS)
        multiCounter[currCounter].W_lshl++;
#endif

        return (L64_var_out);
    }

    /*_____________________________________________________________________________
    |                                                                              |
    |   Function Name : W_lshr                                                     |
    |                                                                              |
    |   Purpose :                                                                  |
    |                                                                              |
    |   Logically shift the 64 bit unsigned input L64_var1 right by var2 positions.|
    |   Zero fill the var2 MSB of the result. If var2 is negative, logically shift |
    |   L64_var1 left by -var2 with zero fill in the LSB.                          |
    |                                                                              |
    |   Complexity weight : 1                                                      |
    |                                                                              |
    |   Inputs :                                                                   |
    |                                                                              |
    |    L64_var1  64 bit long unsigned signed integer (UWord64) whose value falls | 
    |    in the range : 0LL <= L64_var1 <= 0xffffffff ffffffffLL.                  |
    |                                                                              |
    |    var2                                                                      |
    |             16 bit short signed integer (Word16) whose value falls in the    |
    |             range : 0xffff 8000 <= var1 <= 0x0000 7fff.                      |
    |                                                                              |
    |   Outputs :                                                                  |
    |                                                                              |
    |    none                                                                      |
    |                                                                              |
    |   Return Value :                                                             |
    |                                                                              |
    |    L64_var_out                                                               |
    |             64 bit long unsigned signed integer (UWord64) whose value falls  | 
    |    in the range : 0LL <= L64_var1 <= 0xffffffff ffffffffLL.                  |
    |______________________________________________________________________________|
    */
    public static UWord64 W_lshr(UWord64 L64_var1, Word16 var2)
    {

        UWord64 L64_var_out = 0L;

        if (var2 < 0)
        {
            L64_var_out = L64_var1 << (-var2);
        }
        else
        {
            L64_var_out = L64_var1 >> var2;
        }
#if (WMOPS)
        multiCounter[currCounter].W_lshr++;
#endif

        return (L64_var_out);
    }


    /*__________________________________________________________________________________
    |                                                                                  |
    |   Function Name : W_round64_L                                                    |
    |                                                                                  |
    |   Purpose :                                                                      |
    |                                                                                  |
    |  Round asymmetrically lower 32 bits, and                                         | 
    |  saturate the 1.63-bit values to 1.31-bit values                                 | 
    |   Complexity weight : 1                                                          |
    |                                                                                  |
    |   Inputs :                                                                       |
    |                                                                                  |
    |    L64_var1                                                                      |
    |             64 bit long long signed integer (Word64) whose value falls in        |
    |             range : 0x80000000 00000000LL <= L64_var1 <= 0x7fffffff ffffffffLL.  |
    |                                                                                  |
    |   Outputs :                                                                      |
    |                                                                                  |
    |    none                                                                          |
    |                                                                                  |
    |   Return Value :                                                                 |
    |                                                                                  |
    |    L_var_out                                                                     |
    |             32 bit long signed integer (Word32) whose value falls in the         |
    |             range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.                     |
    |__________________________________________________________________________________|
    */
    public static Word32 W_round64_L(Word64 L64_var1)
    {
        Word64 L64_var_out;
        Word32 L_result;


        Word64 L64_tmp = 0x80000000;
        L64_var_out = W_add(L64_var1, L64_tmp);
        L_result = W_extract_h(L64_var_out);

#if (WMOPS)
        multiCounter[currCounter].W_round64_L++;
        multiCounter[currCounter].W_extract_h--;
        multiCounter[currCounter].W_add--;
#endif

        return (L_result);
    }

#endif

    /*****************************************************************************
     *
     *  Function Name : lshl
     *
     *  Purpose :
     *
     *    Logically shifts left var1 by var2 positions.
     *    - If var2 is negative, var1 is shifted to the LSBits by (-var2)
     *      positions with insertion of 0 at the MSBit.
     *    - If var2 is positive, var1 is shifted to the MSBits by (var2)
     *      positions.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    var1        16 bit short signed integer (Word16) whose value falls in 
     *                the range 0xffff 8000 <= var1 <= 0x0000 7fff.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in 
     *                the range 0xffff 8000 <= var2 <= 0x0000 7fff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value:
     *
     *    var_out     16 bit short signed integer (Word16) whose value falls in 
     *                the range 0xffff 8000 <= var_out <= 0x0000 7fff.
     *
     *****************************************************************************/
    public static Word16 lshl(Word16 var1, Word16 var2)
    {
        Word16 var_out = 0;

        if (var2 < 0)
        {
            var2 = (Word16)(-var2);
            var_out = lshr(var1, var2);

#if (WMOPS)
            multiCounter[currCounter].lshr--;
#endif

        }
        else
        {
            if (var2 == 0 || var1 == 0)
            {
                var_out = var1;
            }
            else if (var2 >= 16)
            {
                var_out = 0;
            }
            else
            {
                var_out = (Word16)(var1 << var2);
            }
        }
#if (WMOPS)
        multiCounter[currCounter].lshl++;
#endif

        return (var_out);
    }

    /*****************************************************************************
     *
     *  Function Name : lshr
     *
     *  Purpose :
     *
     *    Logically shifts right var1 by var2 positions.
     *    - If var2 is positive, var1 is shifted to the LSBits by (var2)
     *      positions with insertion of 0 at the MSBit.
     *    - If var2 is negative, var1 is shifted to the MSBits by (-var2)
     *      positions.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    var1        16 bit short signed integer (Word16) whose value falls in 
     *                the range 0xffff 8000 <= var1 <= 0x0000 7fff.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in 
     *                the range 0xffff 8000 <= var2 <= 0x0000 7fff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value:
     *
     *    var_out     16 bit short signed integer (Word16) whose value falls in 
     *                the range 0xffff 8000 <= var_out <= 0x0000 7fff.
     *
     *****************************************************************************/
    public static Word16 lshr(Word16 var1, Word16 var2)
    {
        Word16 var_out;

        if (var2 < 0)
        {
            var2 = (Word16)(-var2);
            var_out = lshl(var1, var2);

#if (WMOPS)
            multiCounter[currCounter].lshl--;
#endif

        }
        else
        {
            if (var2 == 0 || var1 == 0)
            {
                var_out = var1;
            }
            else if (var2 >= 16)
            {
                var_out = 0;
            }
            else
            {
                var_out = (Word16)(var1 >> 1);
                var_out = (Word16)(var_out & 0x7fff);
                var_out = (Word16)(var_out >> (var2 - 1));
            }
        }
#if (WMOPS)
        multiCounter[currCounter].lshr++;
#endif

        return (var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L_lshl
     *
     *  Purpose :
     *
     *    Logically shifts left L_var1 by var2 positions.
     *    - If var2 is negative, L_var1 is shifted to the LSBits by (-var2)
     *      positions with insertion of 0 at the MSBit.
     *    - If var2 is positive, L_var1 is shifted to the MSBits by (var2)
     *      positions.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L_var1      32 bit long signed integer (Word32) whose value falls in 
     *                the range 0x8000 0000 <= L_var1 <= 0x7fff ffff.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in 
     *                the range 0xffff 8000 <= var2 <= 0x0000 7fff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value:
     *
     *    L_var_out   32 bit long signed integer (Word32) whose value falls in 
     *                the range 0x8000 0000 <= L_var_out <= 0x7fff ffff.
     *
     *****************************************************************************/
    public static Word32 L_lshl(Word32 L_var1, Word16 var2)
    {
        Word32 L_var_out = 0;

        if (var2 < 0)
        {
            var2 = (Word16)(-var2);
            L_var_out = L_lshr(L_var1, var2);

#if (WMOPS)
            multiCounter[currCounter].L_lshr--;
#endif

        }
        else
        {
            if (var2 == 0 || L_var1 == 0)
            {
                L_var_out = L_var1;
            }
            else if (var2 >= 32)
            {
                L_var_out = 0;
            }
            else
            {
                L_var_out = L_var1 << var2;
            }
        }
#if (WMOPS)
        multiCounter[currCounter].L_lshl++;
#endif

        return (L_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L_lshr
     *
     *  Purpose :
     *
     *    Logically shifts right L_var1 by var2 positions.
     *    - If var2 is positive, L_var1 is shifted to the LSBits by (var2)
     *      positions with insertion of 0 at the MSBit.
     *    - If var2 is negative, L_var1 is shifted to the MSBits by (-var2)
     *      positions.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L_var1      32 bit long signed integer (Word32) whose value falls in 
     *                the range 0x8000 0000 <= L_var1 <= 0x7fff ffff.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in 
     *                the range 0xffff 8000 <= var2 <= 0x0000 7fff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value:
     *
     *    L_var_out   32 bit long signed integer (Word32) whose value falls in 
     *                the range 0x8000 0000 <= L_var_out <= 0x7fff ffff.
     *
     *****************************************************************************/
    public static Word32 L_lshr(Word32 L_var1, Word16 var2)
    {
        Word32 L_var_out;

        if (var2 < 0)
        {
            var2 = (Word16)(-var2);
            L_var_out = L_lshl(L_var1, var2);

#if (WMOPS)
            multiCounter[currCounter].L_lshl--;
#endif

        }
        else
        {
            if (var2 == 0 || L_var1 == 0)
            {
                L_var_out = L_var1;
            }
            else if (var2 >= 32)
            {
                L_var_out = 0;
            }
            else
            {
                L_var_out = L_var1 >> 1;
                L_var_out = L_var_out & 0x7fffffff;
                L_var_out = L_var_out >> (var2 - 1);
            }
        }
#if (WMOPS)
        multiCounter[currCounter].L_lshr++;
#endif

        return (L_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : shl_r
     *
     *  Purpose :
     *
     *    Identical to shl( var1, var2) but with rounding. Saturates the result
     *    in case of underflows or overflows.
     *
     *  Complexity weight : 3
     *
     *  Inputs :
     *
     *    var1        16 bit short signed integer (Word16) whose value falls in 
     *                the range : 0xffff 8000 <= var1 <= 0x0000 7fff.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in 
     *                the range : 0xffff 8000 <= var2 <= 0x0000 7fff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    var_out     16 bit short signed integer (Word16) whose value falls in 
     *                the range : 0xffff 8000 <= var_out <= 0x0000 7fff.
     *
     *****************************************************************************/
    public static Word16 shl_r(Word16 var1, Word16 var2)
    {
        Word16 var_out;

        if (var2 >= 0)
        {
            var_out = shl(var1, var2);

#if (WMOPS)
            multiCounter[currCounter].shl--;
#endif

        }
        else
        {
            var2 = (Word16)(-var2);
            var_out = shr_r(var1, var2);

#if (WMOPS)
            multiCounter[currCounter].shr_r--;
#endif
        }

#if (WMOPS)
        multiCounter[currCounter].shl_r++;
#endif

        return (var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L_shl_r
     *
     *  Purpose :
     *
     *   Same as L_shl( var1, var2) but with rounding. Saturates the result in
     *   case of underflows or overflows.
     *
     *  Complexity weight : 3
     *
     *  Inputs :
     *
     *    L_var1      32 bit long signed integer (Word32) whose value falls in 
     *                the range : 0x8000 0000 <= L_var1 <= 0x7fff ffff.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in 
     *                the range : 0xffff 8000 <= var2 <= 0x0000 7fff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L_var_out   32 bit long signed integer (Word32) whose value falls in 
     *                the range : 0x8000 0000 <= var_out <= 0x7fff ffff.
     *
     *****************************************************************************/
    public static Word32 L_shl_r(Word32 L_var1, Word16 var2)
    {
        Word32 var_out;

        if (var2 >= 0)
        {
            var_out = L_shl(L_var1, var2);

#if (WMOPS)
            multiCounter[currCounter].L_shl--;
#endif

        }
        else
        {
            var2 = (Word16)(-var2);
            var_out = L_shr_r(L_var1, var2);

#if (WMOPS)
            multiCounter[currCounter].L_shr_r--;
#endif
        }

#if (WMOPS)
        multiCounter[currCounter].L_shl_r++;
#endif

        return (var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : rotr
     *
     *  Purpose :
     *
     *    Performs a 16-bit logical rotation of var1 by 1 bit to the LSBits. The
     *    MSBit is set to var2 bit 0. The LSBit of var1 is kept in *var3 bit 0.
     *
     *  Complexity weight : 3
     *
     *  Inputs :
     *
     *    var1        16 bit short signed integer (Word16) whose value falls in
     *                the range : 0xffff 8000 <= var1 <= 0x0000 7fff.
     *
     *    var2        16 bit short signed integer (Word16) whose value must be 0
     *                or 1.
     *
     *  Outputs :
     *
     *    *var3       Points on a 16 bit short signed integer (Word16) whose 
     *                value will be 0 or 1.
     *
     *  Return Value :
     *
     *    var_out     16 bit short signed integer (Word16) whose value falls in
     *                the range : 0xffff 8000 <= var_out <= 0x0000 7fff.
     *
     *****************************************************************************/
    public static Word16 rotr(Word16 var1, Word16 var2, Word16* var3)
    {
        Word16 var_out;

        *var3 = s_and(var1, 0x1);
        var_out = s_or(lshr(var1, 1), lshl(var2, 15));

#if (WMOPS)
        multiCounter[currCounter].s_and--;
        multiCounter[currCounter].lshl--;
        multiCounter[currCounter].lshr--;
        multiCounter[currCounter].s_or--;
        multiCounter[currCounter].rotr++;
#endif

        return (var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : rotl
     *
     *  Purpose :
     *
     *    Performs a 16-bit logical rotation of var1 by 1 bit to the MSBits. The
     *    LSBit is set to var2 bit 0. The MSBit of var1 is kept in *var3 bit 0.
     *
     *  Complexity weight : 3
     *
     *  Inputs :
     *
     *    var1        16 bit short signed integer (Word16) whose value falls in
     *                the range : 0xffff 8000 <= var1 <= 0x0000 7fff.
     *
     *    var2        16 bit short signed integer (Word16) whose value must be 0
     *                or 1.
     *
     *  Outputs :
     *
     *    *var3       Points on a 16 bit short signed integer (Word16) whose 
     *                value will be 0 or 1.
     *
     *  Return Value :
     *
     *    var_out     16 bit short signed integer (Word16) whose value falls in
     *                the range : 0xffff 8000 <= var_out <= 0x0000 7fff.
     *
     *****************************************************************************/
    public static Word16 rotl(Word16 var1, Word16 var2, Word16* var3)
    {
        Word16 var_out;

        *var3 = lshr(var1, 15);

        var_out = s_or(lshl(var1, 1), s_and(var2, 0x1));

#if (WMOPS)
        multiCounter[currCounter].lshr--;
        multiCounter[currCounter].s_and--;
        multiCounter[currCounter].lshl--;
        multiCounter[currCounter].s_or--;
        multiCounter[currCounter].rotl++;
#endif

        return (var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L_rotr
     *
     *  Purpose :
     *
     *    Performs a 32-bit logical rotation of L_var1 by 1 bit to the LSBits. The
     *    MSBit is set to var2 bit 0. The LSBit of L_var1 is kept in *var3 bit 0.
     *
     *  Complexity weight : 3
     *
     *  Inputs :
     *
     *    L_var1      32 bit long signed integer (Word32) whose value falls in
     *                the range : 0x8000 0000 <= L_var1 <= 0x7fff ffff.
     *
     *    var2        16 bit short signed integer (Word16) whose value must be 0
     *                or 1.
     *
     *  Outputs :
     *
     *    *var3       Points on a 16 bit short signed integer (Word16) whose 
     *                value will be 0 or 1.
     *
     *  Return Value :
     *
     *    L_var_out   32 bit long signed integer (Word32) whose value falls in
     *                the range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.
     *
     *****************************************************************************/
    public static Word32 L_rotr(Word32 L_var1, Word16 var2, Word16* var3)
    {
        Word32 L_var_out;

        *var3 = s_and(extract_l(L_var1), 0x1);

        L_var_out = L_or(L_lshr(L_var1, 1), L_lshl(L_deposit_l(var2), 31));

#if (WMOPS)
        multiCounter[currCounter].extract_l--;
        multiCounter[currCounter].s_and--;
        multiCounter[currCounter].L_deposit_l--;
        multiCounter[currCounter].L_lshl--;
        multiCounter[currCounter].L_lshr--;
        multiCounter[currCounter].L_or--;
        multiCounter[currCounter].L_rotr++;
#endif

        return (L_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L_rotl
     *
     *  Purpose :
     *
     *    Performs a 32-bit logical rotation of L_var1 by 1 bit to the MSBits. The
     *    LSBit is set to var2 bit 0. The MSBit of L_var1 is kept in *var3 bit 0.
     *
     *  Complexity weight : 3
     *
     *  Inputs :
     *
     *    L_var1      32 bit long signed integer (Word32) whose value falls in
     *                the range : 0x8000 0000 <= L_var1 <= 0x7fff ffff.
     *
     *    var2        16 bit short signed integer (Word16) whose value must be 0
     *                or 1.
     *
     *  Outputs :
     *
     *    *var3       Points on a 16 bit short signed integer (Word16) whose 
     *                value will be 0 or 1.
     *
     *  Return Value :
     *
     *    L_var_out   32 bit long signed integer (Word32) whose value falls in
     *                the range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.
     *
     *****************************************************************************/
    public static Word32 L_rotl(Word32 L_var1, Word16 var2, Word16* var3)
    {
        Word32 L_var_out;

        *var3 = extract_l(L_lshr(L_var1, 31));

        L_var_out = L_or(L_lshl(L_var1, 1), L_deposit_l(s_and(var2, 0x1)));

#if (WMOPS)
        multiCounter[currCounter].L_lshr--;
        multiCounter[currCounter].extract_l--;
        multiCounter[currCounter].s_and--;
        multiCounter[currCounter].L_deposit_l--;
        multiCounter[currCounter].L_lshl--;
        multiCounter[currCounter].L_or--;
        multiCounter[currCounter].L_rotl++;
#endif

        return (L_var_out);
    }

    /*****************************************************************************
     *
     *  Function Name : s_max
     *
     *  Purpose :
     *
     *    Compares var1 and var2 and returns the maximum value.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    var1        16 bit short signed integer (Word16) whose value falls in 
     *                the range : 0x8000 <= var1 <= 0x7fff.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in
     *                the range : 0x8000 <= var2 <= 0x7fff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    var_out     16 bit short signed integer (Word16) whose value falls in
     *                the range : 0x8000 <= L_var_out <= 0x7fff.
     *
     *****************************************************************************/
    public static Word16 s_max(Word16 var1, Word16 var2)
    {
        Word16 var_out;

        if (var1 >= var2)
            var_out = var1;
        else
            var_out = var2;

#if (WMOPS)
        multiCounter[currCounter].s_max++;
#endif

        return (var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : s_min
     *
     *  Purpose :
     *
     *    Compares var1 and var2 and returns the minimum value.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    var1        16 bit short signed integer (Word16) whose value falls in 
     *                the range : 0x8000  <= var1 <= 0x7fff.
     *
     *    var2        16 bit short signed integer (Word16) whose value falls in 
     *                the range : 0x8000  <= var2 <= 0x7fff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    var_out     16 bit short signed integer (Word16) whose value falls in 
     *                the range : 0x8000 <= var_out <= 0x7fff.
     *
     *****************************************************************************/
    public static Word16 s_min(Word16 var1, Word16 var2)
    {
        Word16 var_out;

        if (var1 <= var2)
            var_out = var1;
        else
            var_out = var2;

#if (WMOPS)
        multiCounter[currCounter].s_min++;
#endif

        return (var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L_max
     *
     *  Purpose :
     *
     *    Compares L_var1 and L_var2 and returns the maximum value.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L_var1      32 bit long signed integer (Word32) whose value falls in the
     *                range : 0x8000 0000  <= L_var1 <= 0x7fff ffff.
     *
     *    L_var2      32 bit long signed integer (Word32) whose value falls in the
     *                range : 0x8000 0000  <= L_var2 <= 0x7fff ffff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L_var_out   32 bit long signed integer (Word32) whose value falls in the
     *                range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.
     *
     *****************************************************************************/
    public static Word32 L_max(Word32 L_var1, Word32 L_var2)
    {
        Word32 L_var_out;

        if (L_var1 >= L_var2)
            L_var_out = L_var1;
        else
            L_var_out = L_var2;

#if (WMOPS)
        multiCounter[currCounter].L_max++;
#endif

        return (L_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L_min
     *
     *  Purpose :
     *
     *    Compares L_var1 and L_var2 and returns the minimum value.
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L_var1      32 bit long signed integer (Word32) whose value falls in the
     *                range : 0x8000 0000  <= L_var1 <= 0x7fff ffff.
     *
     *    L_var2      32 bit long signed integer (Word32) whose value falls in the
     *                range : 0x8000 0000  <= L_var2 <= 0x7fff ffff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L_var_out   32 bit long signed integer (Word32) whose value falls in the
     *                range : 0x8000 0000 <= L_var_out <= 0x7fff ffff.
     *
     *****************************************************************************/
    public static Word32 L_min(Word32 L_var1, Word32 L_var2)
    {
        Word32 L_var_out;

        if (L_var1 <= L_var2)
            L_var_out = L_var1;
        else
            L_var_out = L_var2;

#if (WMOPS)
        multiCounter[currCounter].L_min++;
#endif

        return (L_var_out);
    }










    /*****************************************************************************
     *
     *  Function Name : s_and
     *
     *  Purpose :
     *
     *    Performs logical AND of the two 16 bit input variables.
     *    var_out = var1 & var2
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    var1        16 bit short signed integer (Word16) whose value
     *                falls in the range 0xffff 8000 <= var1 <= 0x0000 7fff.
     *
     *    var2        16 bit short signed integer (Word16) whose value
     *                falls in the range 0xffff 8000 <= var2 <= 0x0000 7fff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    var_out     16 bit short signed integer (Word16) whose value
     *                falls in the range 0xffff 8000 <= var_out <= 0x0000 7fff.
     *
     *****************************************************************************/
    public static Word16 s_and(Word16 var1, Word16 var2)
    {
        Word16 var_out;

        var_out = (Word16)(var1 & var2);

#if (WMOPS)
        multiCounter[currCounter].s_and++;
#endif

        return (var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L_and
     *
     *  Purpose :
     *
     *    Performs logical AND of the two 32 bit input variables.
     *    L_var_out = L_var1 & L_var2
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L_var1      32 bit long signed integer (Word32) whose value
     *                falls in the range 0x8000 0000 <= L_var1 <= 0x7fff ffff.
     *
     *    L_var2      32 bit long signed integer (Word32) whose value
     *                falls in the range 0x8000 0000 <= L_var2 <= 0x7fff ffff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L_var_out   32 bit long signed integer (Word32) whose value
     *                falls in the range 0x8000 0000 <= L_var_out <= 0x7fff ffff.
     *
     *****************************************************************************/
    public static Word32 L_and(Word32 L_var1, Word32 L_var2)
    {
        Word32 L_var_out;

        L_var_out = L_var1 & L_var2;

#if (WMOPS)
        multiCounter[currCounter].L_and++;
#endif

        return (L_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : s_or
     *
     *  Purpose :
     *
     *    Performs logical OR of the two 16 bit input variables.
     *    var_out = var1 | var2
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    var1        16 bit short signed integer (Word16) whose value
     *                falls in the range 0xffff 8000 <= var1 <= 0x0000 7fff.
     *
     *    var2        16 bit short signed integer (Word16) whose value
     *                falls in the range 0xffff 8000 <= var2 <= 0x0000 7fff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    var_out     16 bit short signed integer (Word16) whose value
     *                falls in the range 0xffff 8000 <= var_out <= 0x0000 7fff.
     *
     *****************************************************************************/
    public static Word16 s_or(Word16 var1, Word16 var2)
    {
        Word16 var_out;

        var_out = (Word16)(var1 | var2);

#if (WMOPS)
        multiCounter[currCounter].s_or++;
#endif

        return (var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L_or
     *
     *  Purpose :
     *
     *    Performs logical OR of the two 32 bit input variables.
     *    L_var_out = L_var1 | L_var2
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L_var1      32 bit long signed integer (Word32) whose value
     *                falls in the range 0x8000 0000 <= L_var1 <= 0x7fff ffff.
     *
     *    L_var2      32 bit long signed integer (Word32) whose value
     *                falls in the range 0x8000 0000 <= L_var2 <= 0x7fff ffff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L_var_out   32 bit long signed integer (Word32) whose value
     *                falls in the range 0x8000 0000 <= L_var_out <= 0x7fff ffff.
     *
     *****************************************************************************/
    public static Word32 L_or(Word32 L_var1, Word32 L_var2)
    {

        Word32 L_var_out;

        L_var_out = L_var1 | L_var2;

#if (WMOPS)
        multiCounter[currCounter].L_or++;
#endif

        return (L_var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : s_xor
     *
     *  Purpose :
     *
     *    Performs logical XOR of the two 16 bit input variables.
     *    var_out = var1 ^ var2
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    var1        16 bit short signed integer (Word16) whose value
     *                falls in the range 0xffff 8000 <= var1 <= 0x0000 7fff.
     *
     *    var2        16 bit short signed integer (Word16) whose value
     *                falls in the range 0xffff 8000 <= var2 <= 0x0000 7fff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    var_out     16 bit short signed integer (Word16) whose value
     *                falls in the range 0xffff 8000 <= var_out <= 0x0000 7fff.
     *
     *****************************************************************************/
    public static Word16 s_xor(Word16 var1, Word16 var2)
    {
        Word16 var_out;

        var_out = (Word16)(var1 ^ var2);

#if (WMOPS)
        multiCounter[currCounter].s_xor++;
#endif

        return (var_out);
    }


    /*****************************************************************************
     *
     *  Function Name : L_xor
     *
     *  Purpose :
     *
     *    Performs logical OR of the two 32 bit input variables.
     *    L_var_out = L_var1 ^ L_var2
     *
     *  Complexity weight : 1
     *
     *  Inputs :
     *
     *    L_var1      32 bit long signed integer (Word32) whose value
     *                falls in the range 0x8000 0000 <= L_var1 <= 0x7fff ffff.
     *
     *    L_var2      32 bit long signed integer (Word32) whose value
     *                falls in the range 0x8000 0000 <= L_var2 <= 0x7fff ffff.
     *
     *  Outputs :
     *
     *    none
     *
     *  Return Value :
     *
     *    L_var_out   32 bit long signed integer (Word32) whose value
     *                falls in the range 0x8000 0000 <= L_var_out <= 0x7fff ffff.
     *
     *****************************************************************************/
    public static Word32 L_xor(Word32 L_var1, Word32 L_var2)
    {
        Word32 L_var_out;

        L_var_out = L_var1 ^ L_var2;

#if (WMOPS)
        multiCounter[currCounter].L_xor++;
#endif

        return (L_var_out);
    }

    /*___________________________________________________________________________
 |                                                                           |
 |   Function Name : UL_deposit_l                                            |
 |                                                                           |
 |   Purpose :                                                               |
 |                                                                           |
 |   Deposit the 16 bit var1 into the 16 LS bits of the 32 bit output. The   |
 |   16 MS bits of the output are not sign extended.                         |
 |___________________________________________________________________________|
*/

    public static UWord32 UL_deposit_l(UWord16 uvar)
    {
        UWord32 UL_result;
        UL_result = (UWord32)uvar;   /* no sign extension*/
#if (WMOPS)
        multiCounter[currCounter].UL_deposit_l++;
#endif
        return (UL_result);
    }

    /*_____________________________________________________________________________
     |                                                                             |
     |   Function Name : norm_ul                                                   |
     |                                                                             |
     |   Purpose :                                                                 |
     |                                                                             |
     |   Produces the number of left shifts needed to normalize the 32 bit varia-  |
     |   ble UL_var1 for positive values on the interval with minimum of           |
     |   0 and maximum of 0xffffffff, ; in order to normalize the                  | 
     |   result, the following operation must be done :                            |
     |                                                                             |
     |      norm_UL_var1 = UL_lshl(UL_var1, norm_ul(UL_var1)).                     |
     |                                                                             |
     |   Complexity weight : 1                                                     |
     |                                                                             |
     |   Inputs :                                                                  |
     |                                                                             |
     |     UL_var1                                                                 |
     |       32 bit long unsigned integer (UWord32) whose value falls in the       |
     |       range : 0x0000 0000 <= var1 <= 0xffff ffff.                           |
     |                                                                             |
     |   Outputs :                                                                 |
     |                                                                             |
     |     none                                                                    |
     |                                                                             |
     |   Return Value :                                                            |
     |                                                                             |
     |     var_out                                                                 |
     |        16 bit short signed integer (Word16) whose value falls in the        |
     |        range : 0x0000 0000 <= var_out <= 0x0000 001f. (0..31d)              |
     |_____________________________________________________________________________|
    */
    public static Word16 norm_ul(UWord32 UL_var1)
    {
        Word16 var_out;

        if (UL_var1 == 0)
        {
            var_out = 0;
        }
        else
        {
            /* simply test shift up until  highest bit is set */
            for (var_out = 0; UL_var1 < (UWord32)0x80000000U; var_out++)
            {
                UL_var1 <<= 1;
            }
        }

#if (WMOPS)
        multiCounter[currCounter].norm_ul++;
#endif

        return (var_out);
    }

    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : UL_addNs                                                |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   32 bits addition of the two unsigned 32 bits variables                  |
     |   (L_var1+L_var2) with overflow control, but without saturation           |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |     *wrap = 1 if wrap occured, otherwize 0                                |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |     UL_var3 = modulo(UL_var1+UL_var2,32)                                  |
     |___________________________________________________________________________|
    */

    public static UWord32 UL_addNs(UWord32 UL_var1, UWord32 UL_var2, UWord16* wrap)
    {
        UWord32 UL_var3;

        /* STL Overflow flag is not updated */
        UL_var3 = UL_var1 + UL_var2;        /* 32-bit wrap  may occur, like in C */

        if (((UWord64)UL_var1 + (UWord64)UL_var2) > 0xFFFFFFFFU)
        {
            *wrap = 1;  /* wrapped output */
        }
        else
        {
            *wrap = 0;
        }

#if WMOPS
        multiCounter[currCounter].UL_addNs++;
#endif

        return UL_var3;
    }

    /*___________________________________________________________________________
     |                                                                           |
     |   Function Name : UL_subNs                                                |
     |                                                                           |
     |   Purpose :                                                               |
     |                                                                           |
     |   32 bits subtraction of the two unsigned 32 bits variables               |
     |   (L_var1-L_var2) with  overflow control, but without saturation          |
     |                                                                           |
     |   Outputs :                                                               |
     |                                                                           |
     |     *sgn = 1 if wrap (to "negative" occured, otherwise 0)                 |
     |                                                                           |
     |   Return Value :                                                          |
     |                                                                           |
     |     UL_var3 = modulo(UL_var1-UL_var2,32)                                  |
     |___________________________________________________________________________|
    */

    public static UWord32 UL_subNs(UWord32 UL_var1, UWord32 UL_var2, UWord16* sgn)
    {
        UWord32 UL_var3;

        UL_var3 = UL_var1 - UL_var2; /*wrap  may occur, like in C */
        if (UL_var1 >= UL_var2)
        {
            *sgn = 0;
        }
        else
        {
            *sgn = 1; /* "negative", wrapped output */
        }

#if WMOPS
        multiCounter[currCounter].UL_subNs++;
#endif
        return UL_var3;
    }

    /*________________________________________________________________________________
     |                                                                                |
     |  Function Name : Mpy_32_16_uu                                                  |
     |                                                                                |
     |  Purpose :                                                                     |
     |                                                                                |
     |    Multiplies the 2 unsigned values UL_var1 and uvar2.                         |
     |    The operation is performed in fractional mode :                             |
     |    - UL_var1 is supposed to be in Q32 format.                                  |
     |    - var2   is supposed to be in Q16 format.                                   |
     |    - The result is produced in Q48 format : UL_varout_h points to the          |
     |      32 MSBits while varout_l points to the 16 LSBits.                         |
     |                                                                                |
     |  Complexity weight : 2                                                         |
     |                                                                                |
     |  Inputs :                                                                      |
     |                                                                                |
     |    UL_var1   32 bit long unsigned integer (UWord32) whose value falls in       |
     |              the range : 0x0000 0000 <= L_var1 <= 0xffff ffff.                 |
     |                                                                                |
     |    var2      16 bit short unsigned integer (UWord16) whose value falls in      |
     |              the range : 0x0000 <= var2 <= 0x0000 ffff.                        |
     |                                                                                |
     |  Outputs :                                                                     |
     |                                                                                |
     |    *UL_varout_h   32 bit long unsigned integer (UWord32) whose value falls in  |
     |                   the range : 0x0000 0000 <= UL_varout_h <= 0xffff ffff.       |
     |                                                                                |
     |    *varout_l      16 bit short unsigned integer (UWord16) whose value falls in |
     |                   the range : 0x0000 0000 <= varout_l <= 0x0000 ffff.          |
     |                                                                                |
     |  Return Value :                                                                |
     |                                                                                |
     |    none                                                                        |
     |________________________________________________________________________________|
    */
    public static void Mpy_32_16_uu(UWord32 UL_var1, UWord16 uvar2, UWord32* UL_varout_h, UWord16* varout_l)
    {
        UWord64 UL64_var1;

        /* 4294967295  * 65535  <  281474976710655 */
        /* (uint64(2)^16-1 )*(uint64(2)^32-1) < (uint64(2)^(16+32)-1) */
        UL64_var1 = ((UWord64)UL_var1) * ((UWord64)uvar2);
        *varout_l = (UWord16)UL64_var1;
        *UL_varout_h = (UWord32)(UL64_var1 >> 16);

#if (WMOPS)
        multiCounter[currCounter].Mpy_32_16_uu++;
#endif

        return;
    }

    /*__________________________________________________________________________________
     |                                                                                  |
     |  Function Name : Mpy_32_32_uu                                                    |
     |                                                                                  |
     |  Purpose :                                                                       |
     |                                                                                  |
     |    Multiplies the 2 unsigned values UL_var1 and UL_var2.                         |
     |    The operation is performed in fractional mode :                               |
     |    - UL_var1 and UL_var2 are supposed to be in Q32 format.                       |
     |    - The result is produced in Q64 format : UL_varout_h points to the            |
     |      32 MSBits while UL_varout_l points to the 32 LSBits.                        |
     |                                                                                  |
     |  Complexity weight : 4                                                           |
     |                                                                                  |
     |  Inputs :                                                                        |
     |                                                                                  |
     |    UL_var1      32 bit long unsigned integer (UWord32) whose value falls in the  |
     |                 range : 0x0000 0000  <= L_var1 <= 0xffff ffff.                   |
     |                                                                                  |
     |    UL_var2      32 bit long unsigned integer (UWord32) whose value falls in the  |
     |                 range : 0x0000 0000  <= L_var2 <= 0xffff ffff.                   |
     |                                                                                  |
     |  Outputs :                                                                       |
     |                                                                                  |
     |    *UL_varout_h   32 bit long signed integer (Word32) whose value falls in       |
     |                   the range : 0x0000 0000 <= UL_varout_h <= 0xffff ffff.         |
     |                                                                                  |
     |    *UL_varout_l   32 bit short unsigned integer (UWord32) whose value falls in   |
     |                   the range : 0x0000 0000 <= UL_varout_l <= 0xffff ffff.         |
     |                                                                                  |
     |  Return Value :                                                                  |
     |                                                                                  |
     |    none                                                                          |
     |__________________________________________________________________________________|
     */
    public static void Mpy_32_32_uu(UWord32 UL_var1, UWord32 UL_var2, UWord32* UL_varout_h, UWord32* UL_varout_l)
    {
        UWord64 UL64_var1;
        /* (uint64(2)^32-1 )*(uint64(2)^32-1) < (uint64(2)^(32+32)-1) */
        UL64_var1 = ((UWord64)UL_var1) * ((UWord64)UL_var2);
        *UL_varout_h = (UWord32)(UL64_var1 >> 32);
        *UL_varout_l = (UWord32)(UL64_var1);

#if (WMOPS)
        multiCounter[currCounter].Mpy_32_32_uu++;
#endif

        return;
    }

    /*_____________________________________________________________________________________
     |                                                                                     |
     |  Function Name : UL_Mpy_32_32                                                       |
     |                                                                                     |
     |  Purpose :                                                                          |
     |                                                                                     |
     |    Multiplies the 2 unsigned values UL_var1 and UL_var2                             |
     |    and returns the lower 32 bits, without saturation control.                       |
     |                                                                                     |
     |    - UL_var1 and UL_var2 are supposed to be in Q32 format.                          |
     |    - The result is produced in Q64 format, the 32 LSBits.                           |
     |                                                                                     |
     |      operates like a  regular 32-by-32 bit unsigned int  multiplication in ANSI-C.  |
     |        UWord32) = (unsigned int)*(unsigned int);                                    |
     |                                                                                     |
     |                                                                                     |
     |  Complexity weight : 2                                                              |
     |                                                                                     |
     |  Inputs :                                                                           |
     |                                                                                     |
     |    UL_var1     32 bit long unsigned integer (UWord32) whose value falls in the      |
     |                range : 0x0000 0000  <= UL_var1 <= 0xffff ffff.                      |
     |                                                                                     |
     |    UL_var2     32 bit long unsigned integer (UWord32) whose value falls in the      |
     |                range : 0x0000 0000  <= UL_var2 <= 0xffff ffff.                      |
     |                                                                                     |
     |  Outputs :                                                                          |
     |                                                                                     |
     |    none                                                                             |
     |                                                                                     |
     |  Return Value :                                                                     |
     |    *UL_varout_l   32 bit short unsigned integer (UWord32) whose value falls in      |
     |                   the range : 0x0000 0000 <= UL_varout_l <= 0xffff ffff.            |
     |                                                                                     |
     |_____________________________________________________________________________________|
    */
    public static UWord32 UL_Mpy_32_32(UWord32 UL_var1, UWord32 UL_var2)
    {
        UWord32 UL_varout_l;

        const UWord32 MASK32 = 0xFFFFFFFFu;
        /* MASK32 may be needed in case Hardware is using larger than 32 bits for UWord32 type */
        UL_varout_l = (UL_var1 & MASK32) * (UL_var2 & MASK32);
        UL_varout_l = UL_varout_l & MASK32;

#if (WMOPS)
        multiCounter[currCounter].UL_Mpy_32_32++;
#endif

        return UL_varout_l;
    }

    private static Word40 L40_OVERFLOW_OCCURED(Word40 L40_var1)
    {
        Overflow = 1;
        throw new BasopRuntimeException("unexpected L40 overflow");
        //return L40_var1;
    }

    private static Word40 L40_UNDERFLOW_OCCURED(Word40 L40_var1)
    {
        Overflow = 1;
        throw new BasopRuntimeException("unexpected L40 underflow");
        //return L40_var1;
    }
}
