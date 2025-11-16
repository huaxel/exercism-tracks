; Everything that comes after a semicolon (;) is a comment

; Assembler-time constants may be defined using 'equ'

section .text

; You should implement functions in the .text section

; the global directive makes a function visible to the test files
global expected_minutes_in_oven
expected_minutes_in_oven:
    mov rax, 40         ; Return the number of expected minutes
    ret

global remaining_minutes_in_oven
remaining_minutes_in_oven:
    mov rax, 40         ; Load the expected minutes into rax
    sub rax, rdi        ; Calculate remaining minutes
    ret

global preparation_time_in_minutes
preparation_time_in_minutes:
    mov rax, rdi
    shl rax, 1
    ret
    
global elapsed_time_in_minutes
elapsed_time_in_minutes:
    shl rdi, 1
    mov rax, rdi
    add rax, rsi
    ret
    
%ifidn __OUTPUT_FORMAT__,elf64
section .note.GNU-stack noalloc noexec nowrite progbits
%endif
