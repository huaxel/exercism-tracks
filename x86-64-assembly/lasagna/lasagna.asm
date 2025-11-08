; Everything that comes after a semicolon (;) is a comment

; Assembler-time constants may be defined using 'equ'

section .text

; Implementations for x86-64 calling convention (arguments in registers):
; - return value: rax
; - args: rdi, rsi, rdx, rcx, r8, r9

; the global directive makes a function visible to the test files
global expected_minutes_in_oven
expected_minutes_in_oven:
    mov rax, 40         ; Return the number of expected minutes (int64_t)
    ret

global remaining_minutes_in_oven
remaining_minutes_in_oven:
    ; arg: rdi = actual_minutes_in_oven
    mov rax, 40         ; expected minutes
    sub rax, rdi        ; remaining = expected - actual
    ret

global preparation_time_in_minutes
preparation_time_in_minutes:
    ; arg: rdi = number_of_layers
    mov rax, rdi
    shl rax, 1          ; multiply by 2 (2 minutes per layer)
    ret

global elapsed_time_in_minutes
elapsed_time_in_minutes:
    ; args: rdi = number_of_layers, rsi = actual_minutes_in_oven
    mov rax, rdi
    add rax, rsi        ; elapsed = prep_time + actual_minutes
    ret
    
%ifidn __OUTPUT_FORMAT__,elf64
section .note.GNU-stack noalloc noexec nowrite progbits
%endif
