; Input parameters
; rcx -> pointer to the beginning of the byte array
; rdx -> start of processing section
; r8 -> end of processing section
; r9 -> red color value taken from the slider
; [rsp + 8 * 6] -> green color value taken from the slider
; [rsp + 8 * 7] -> blue color value taken from the slider

.data
MaxByteFloat dd 255.0, 255.0, 255.0, 0.0 ; vector with the maximum values of bytes

.code
AsmColorCorr proc

push rbp								 ; put the rbp register on the stack
mov rbp, rsp							 ; write rsp register to rbp
										 
sub r8, 4								 ; subtracting 4 from the end of the processing section
cmp rdx, r8								 ; compare whether the begining of the section is greater than its end
jg Finish								 ; if it is, a jump to the end of the program is performed
										 
movaps xmm10, MaxByteFloat				 ; writing the vector with the maximum values to xmm10
xorps xmm1, xmm1						 ; xmm1 reset
										 
pinsrd xmm1, dword ptr [rbp+8*7], 0		 ; writing the blue color value to the xmm1 vector
pinsrd xmm1, dword ptr [rbp+8*6], 1		 ; writing the green color value to the xmm1 vector
pinsrd xmm1, r9d, 2						 ; writing the red color value to the xmm1 vector
										 
cvtdq2ps xmm1, xmm1						 ; convert integers to floating point
vsubps xmm1, xmm10, xmm1				 ; subtracting the color values passed to the function from 255
										 
xorps xmm0, xmm0						 ; preparing a register with all zeros
vdivps xmm1, xmm10, xmm1				 ; dividing 255 by the previously calculated values
										 
LoopStart:								 
xorps xmm2, xmm2						 ; xmm2 reset
										 
pinsrb xmm2, byte ptr [rcx+rdx], 0		 ; write the blue value taken from the bitmap into the vector
pinsrb xmm2, byte ptr [rcx+rdx+1], 4	 ; write the green value taken from the bitmap into the vector
pinsrb xmm2, byte ptr [rcx+rdx+2], 8	 ; write the red value taken from the bitmap into the vector
										 
cvtdq2ps xmm2, xmm2						 ; convert integers to floating point
mulps xmm2, xmm1						 ; multiplication of the previously computed values with the values taken from the bitmap
										 
maxps xmm2, xmm0						 ; checking whether after multiplying any of the values has not become negatie, if so, 0 is written insted
minps xmm2, xmm10						 ; checking whether after multiplying any of the values did not came out greater than 255, if so, 255 is written instead
										 
cvttps2dq xmm2, xmm2					 ; convert floating point numbers to integers
										 
pextrb byte ptr [rcx+rdx], xmm2, 0		 ; save the new blue color value to the bitmap in place of the old one
pextrb byte ptr [rcx+rdx+1], xmm2, 4	 ; save the new green color value to the bitmap in place of the old one
pextrb byte ptr [rcx+rdx+2], xmm2, 8	 ; save the new red color value to the bitmap in place of the old one
										 
add edx, 4								 ; shifts the beginning of the section 4 bits forward
cmp edx, r8d							 ; compare the beginning of the section with its end
jle LoopStart							 ; if the start is less than the end, a jump to the beginning of the loop is made
										 
Finish:									 
pop rbp									 ; read rbp register from stack
										 
ret										 ; return from function

AsmColorCorr endp
end