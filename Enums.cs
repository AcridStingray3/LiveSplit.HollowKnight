﻿using System;
using System.Collections.Generic;
using System.Text;
namespace LiveSplit.HollowKnight {
	public enum Offset : int {
		health,
		maxHealthBase,
		MPCharge,
		MPReserveMax,
		mapZone,
		nailDamage,
		fireballLevel,
		quakeLevel,
		screamLevel,
		hasCyclone,
		hasDashSlash,
		hasUpwardSlash,
		hasDreamNail,
		dreamNailUpgraded,
		hasDash,
		hasWallJump,
		hasSuperDash,
		hasShadowDash,
		hasAcidArmour,
		hasDoubleJump,
		hasLantern,
		hasTramPass,
		hasLoveKey,
		hasKingsBrand,
		ore,
		simpleKeys,
		notchShroomOgres,
		notchFogCanyon,
		lurienDefeated,
		hegemolDefeated,
		monomonDefeated,
		visitedDeepnestSpa,
		zoteRescuedBuzzer,
		zoteRescuedDeepnest,
		mothDeparted,
		salubraNotch1,
		salubraNotch2,
		salubraNotch3,
		salubraNotch4,
		nailSmithUpgrades,
		colosseumBronzeCompleted,
		colosseumSilverCompleted,
		colosseumGoldCompleted,
		openedCrossroads,
		openedRuins2,
		openedFungalWastes,
		openedDeepnest,
		gotCharm_1,
		gotCharm_2,
		gotCharm_3,
		gotCharm_4,
		gotCharm_5,
		gotCharm_6,
		gotCharm_7,
		gotCharm_8,
		gotCharm_9,
		gotCharm_10,
		gotCharm_11,
		gotCharm_12,
		gotCharm_13,
		gotCharm_14,
		gotCharm_15,
		gotCharm_16,
		gotCharm_17,
		gotCharm_18,
		gotCharm_19,
		gotCharm_20,
		gotCharm_21,
		gotCharm_22,
		gotCharm_23,
		gotCharm_24,
		gotCharm_25,
		gotCharm_26,
		gotCharm_27,
		gotCharm_28,
		gotCharm_29,
		gotCharm_30,
		gotCharm_31,
		gotCharm_32,
		gotCharm_33,
		gotCharm_34,
		gotCharm_35,
		gotCharm_36,
		gotCharm_37,
		gotCharm_38,
		gotCharm_39,
		gotCharm_40,
		charmCost_36,
		killsSpitter,
		killedBigFly,
		killedMawlek,
		killedMossKnight,
		killedInfectedKnight,
		killedMegaJellyfish,
		killsMushroomBrawler,
		killedBlackKnight,
		killedMageLord,
		killedFlukeMother,
		killedDungDefender,
		killsMegaBeamMiner,
		killedMimicSpider,
		killedHornet,
		killedTraitorLord,
		killedGhostAladar,
		killedGhostXero,
		killedGhostHu,
		killedGhostMarmu,
		killedGhostNoEyes,
		killedGhostMarkoth,
		killedGhostGalien,
		killedHollowKnight,
		killedFinalBoss,
		killedFalseKnight,
		falseKnightDreamDefeated,
		killedGrimm,
		killedNightmareGrimm,
		killedBindingSeal,
		grimmChildLevel,
		nightmareLanternLit,
		destroyedNightmareLantern,
		flamesCollected,
		heartPieces,
		vesselFragments,
		mawlekDefeated,
		collectorDefeated,
		hornetOutskirtsDefeated,
		mageLordDreamDefeated,
		infectedKnightDreamDefeated,
		isInvincible,
		visitedDirtmouth,
		visitedCrossroads,
		visitedGreenpath,
		visitedFungus,
		visitedHive,
		visitedRuins,
		visitedMines,
		visitedRoyalGardens,
		visitedFogCanyon,
		visitedDeepnest,
		visitedRestingGrounds,
		visitedWaterways,
		visitedWhitePalace,
		crossroadsInfected,
		megaMossChargerDefeated,
		defeatedMantisLords,
		defeatedMegaBeamMiner,
		defeatedMegaBeamMiner2,
		gotShadeCharm,
		disablePause,
		mrMushroomState,
		killedWhiteDefender,
		killedGreyPrince,
		hasDreamGate,
		metRelicDealer,
		metRelicDealerShop
	}
	public enum GameState {
		INACTIVE,
		MAIN_MENU,
		LOADING,
		ENTERING_LEVEL,
		PLAYING,
		PAUSED,
		EXITING_LEVEL,
		CUTSCENE,
		PRIMER
	}
	public enum ActorStates {
		GROUNDED,
		IDLE,
		RUNNING,
		AIRBORNE,
		WALL_SLIDING,
		HARD_LANDING,
		DASH_LANDING,
		NO_INPUT,
		PREVIOUS
	}
	public enum HeroTransitionState {
		WAITING_TO_TRANSITION,
		EXITING_SCENE,
		WAITING_TO_ENTER_LEVEL,
		ENTERING_SCENE,
		DROPPING_DOWN
	}
	public enum MapZone {
		NONE,
		TEST_AREA,
		KINGS_PASS,
		CLIFFS,
		TOWN,
		CROSSROADS,
		GREEN_PATH,
		ROYAL_GARDENS,
		FOG_CANYON,
		WASTES,
		DEEPNEST,
		HIVE,
		BONE_FOREST,
		PALACE_GROUNDS,
		MINES,
		RESTING_GROUNDS,
		CITY,
		DREAM_WORLD,
		COLOSSEUM,
		ABYSS,
		ROYAL_QUARTER,
		WHITE_PALACE,
		SHAMAN_TEMPLE,
		WATERWAYS,
		QUEENS_STATION,
		OUTSKIRTS,
		KINGS_STATION,
		MAGE_TOWER,
		TRAM_UPPER,
		TRAM_LOWER,
		FINAL_BOSS,
		SOUL_SOCIETY,
		ACID_LAKE,
		NOEYES_TEMPLE,
		MONOMON_ARCHIVE,
		MANTIS_VILLAGE,
		RUINED_TRAMWAY,
		DISTANT_VILLAGE,
		ABYSS_DEEP,
		ISMAS_GROVE,
		WYRMSKIN,
		LURIENS_TOWER,
		LOVE_TOWER,
		GLADE,
		BLUE_LAKE,
		PEAK,
		JONI_GRAVE,
		OVERGROWN_MOUND,
		CRYSTAL_MOUND,
		BEASTS_DEN
	}
	public enum CameraMode {
		FROZEN,
		FOLLOWING,
		LOCKED,
		PANNING,
		FADEOUT,
		FADEIN,
		PREVIOUS
	}
	public enum TargetMode {
		FOLLOW_HERO,
		LOCK_ZONE,
		BOSS,
		FREE
	}
	public enum MainMenuState {
		LOGO,
		MAIN_MENU,
		OPTIONS_MENU,
		GAMEPAD_MENU,
		KEYBOARD_MENU,
		SAVE_PROFILES,
		AUDIO_MENU,
		VIDEO_MENU,
		EXIT_PROMPT,
		OVERSCAN_MENU,
		GAME_OPTIONS_MENU,
		ACHIEVEMENTS_MENU,
		QUIT_GAME_PROMPT,
		RESOLUTION_PROMPT,
		BRIGHTNESS_MENU,
		PAUSE_MENU,
		PLAY_MODE_MENU,
		EXTRAS_MENU,
		REMAP_GAMEPAD_MENU
	}
	public enum UIState {
		INACTIVE,
		MENU_HOME,
		MENU_OPTIONS,
		MENU_PROFILES,
		LOADING,
		CUTSCENE,
		PLAYING,
		PAUSED,
		OPTIONS
	}
}