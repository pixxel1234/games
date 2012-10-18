/**
\author		Korotkov Andrey aka DRON
\date		04.10.2012 (c)Korotkov Andrey

This file is a part of DGLE project and is distributed
under the terms of the GNU Lesser General Public License.
See "DGLE.h" for more details.
*/

#pragma once

#include "Common.h"

#ifndef NO_BUILTIN_SOUND

#ifdef PLATFORM_WINDOWS
#	include "platform\win\BaseSound.h"
#endif

#define SND_CLAMP(x) (x < -0x8000 ? -0x8000 : (x > 0x7FFF ? 0x7FFF : x))

class CSound: private CBaseSound, public ISound
{
	static const uint _sc_uiFrequency = 44100;
	static const uint _sc_uiBitsPerSample = 16;

	struct TSoundFrame
	{
		int16 i16L, i16R;
	
		TSoundFrame(int16 l, int16 r) : i16L(l), i16R(r) {}
	
		TSoundFrame(short M, float pan) 
		{
			i16L = (int)(M * min(1.f, 1.f - pan));
			i16R = (int)(M * min(1.f, pan + 1.f));
		}
	
		inline TSoundFrame& operator += (const TSoundFrame &s)
		{
			i16L = SND_CLAMP((int)i16L + s.i16L);
			i16R = SND_CLAMP((int)i16R + s.i16R);
			return *this;
		}
	};

	bool _bInited;
	uint32 _ui32BufferSize;

	static void DGLE_API _s_StreamToDeviceCallback(void *pParametr, uint8 *pBufferData);
	void _Render(TSoundFrame *frames, uint uiFramesCount);

public:

	CSound(uint uiInstIdx);
	~CSound();

	DGLE_RESULT DGLE_API SetMasterVolume(uint uiVolume);
	DGLE_RESULT DGLE_API PauseAllChannels(bool bPaused);
	DGLE_RESULT DGLE_API StopAllChannels();
	DGLE_RESULT DGLE_API SetMaxChannelsCount(uint uiCount);
	DGLE_RESULT DGLE_API SetListnerPosition(const TPoint3 &stCoords);
	DGLE_RESULT DGLE_API GetListnerPosition(TPoint3 &stCoords);
	DGLE_RESULT DGLE_API SetListnerOrientation(const TVector3 &stDir, const TVector3 &stUp);
	DGLE_RESULT DGLE_API GetListnerOrientation(TVector3 &stDir, TVector3 &stUp);
	DGLE_RESULT DGLE_API GetType(E_ENGINE_SUB_SYSTEM &eSubsysType);

	IDGLE_BASE_IMPLEMENTATION1(ISound, IEngineSubSystem)
};

#undef SND_CLAMP

#endif