#ifdef GL_FRAGMENT_PRECISION_HIGH
	precision highp float;
	precision highp int;
#else
	precision mediump float;
	precision mediump int;
#endif

#include "Lighting.glsl";
#include "PBRFSInput.glsl";
#include "LayaPBRBRDF.glsl";
#include "GlobalIllumination.glsl";
#include "ShadowHelper.glsl"
#include "PBRCore.glsl";


void main()
{
	fragmentForward();
}