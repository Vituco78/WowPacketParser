using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V5_4_0_17359
{
    public static class Opcodes_5_4_0
    {
        public static BiDictionary<Opcode, int> Opcodes()
        {
            return Opcs;
        }

        private static readonly BiDictionary<Opcode, int> Opcs = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_AREATRIGGER, 0x1907},
            {Opcode.CMSG_AUTH_SESSION, 0x0790},
            {Opcode.CMSG_CAST_SPELL, 0x1429},
            {Opcode.CMSG_CHANNEL_LIST, 0x1C14},
            {Opcode.CMSG_CREATURE_QUERY, 0x1585},
            {Opcode.CMSG_DB_QUERY_BULK, 0x1A8B},
            {Opcode.CMSG_DUNGEON_FINDER_GET_SYSTEM_INFO, 0x1A13},
            {Opcode.CMSG_GAMEOBJECT_QUERY, 0x15A4},
            {Opcode.CMSG_GOSSIP_HELLO, 0x1A3F},
            {Opcode.CMSG_GOSSIP_SELECT_OPTION, 0x136B},
            {Opcode.CMSG_GUILD_REQUEST_PARTY_STATE, 0x1885},
            {Opcode.CMSG_GUILD_ROSTER, 0x0315},
            {Opcode.CMSG_GUILD_QUERY_RANKS, 0x0A1D},
            {Opcode.CMSG_LOAD_SCREEN, 0x160B},
            {Opcode.CMSG_LOG_DISCONNECT, 0x0380},
            {Opcode.CMSG_MESSAGECHAT_SAY, 0x10BE},
            {Opcode.CMSG_MOVE_TIME_SKIPPED, 0x0313},
            {Opcode.CMSG_NAME_QUERY, 0x16DB},
            {Opcode.CMSG_NPC_TEXT_QUERY, 0x108B},
            {Opcode.CMSG_PAGE_TEXT_QUERY, 0x1082},
            {Opcode.CMSG_PET_NAME_QUERY, 0x1428},
            {Opcode.CMSG_PLAYER_LOGIN, 0x1BC7},
            {Opcode.CMSG_REALM_SPLIT, 0x129F},
            {Opcode.CMSG_REDIRECT_AUTH_PROOF, 0x0A93},
            {Opcode.CMSG_REQUEST_PARTY_MEMBER_STATS, 0x16CF},
            {Opcode.CMSG_RESET_FACTION_CHEAT, 0x0A96},
            {Opcode.CMSG_QUERY_WORLD_COUNTDOWN_TIMER, 0x10A8},
            {Opcode.CMSG_QUEST_NPC_QUERY, 0x1084},
            {Opcode.CMSG_QUEST_POI_QUERY, 0x1287},
            {Opcode.CMSG_SAVE_CUF_PROFILES, 0x158D},
            {Opcode.CMSG_SET_SELECTION, 0x1B76},
            {Opcode.CMSG_SUSPEND_TOKEN, 0x0286},
            {Opcode.CMSG_TIME_SYNC_RESP, 0x0784},
            {Opcode.CMSG_VIOLENCE_LEVEL, 0x1927},
            {Opcode.CMSG_UNKNOWN_515, 0x0203},
            {Opcode.CMSG_UNKNOWN_822, 0x0336},
            {Opcode.CMSG_UNKNOWN_903, 0x0387},
            {Opcode.CMSG_UNKNOWN_1815, 0x0717},
            {Opcode.CMSG_UNKNOWN_1827, 0x0723},
            {Opcode.CMSG_UNKNOWN_2874, 0x0B3A},
            {Opcode.CMSG_UNKNOWN_4524, 0x11AC},
            {Opcode.CMSG_UNKNOWN_4831, 0x12DF},
            {Opcode.CMSG_UNKNOWN_5079, 0x13D7},
            {Opcode.CMSG_UNKNOWN_5177, 0x1439},
            {Opcode.CMSG_UNKNOWN_5412, 0x1524},
            {Opcode.CMSG_UNKNOWN_5758, 0x167E},
            {Opcode.CMSG_UNKNOWN_6062, 0x17AE},
            {Opcode.CMSG_UNKNOWN_6083, 0x17C3},
            {Opcode.CMSG_UNKNOWN_6774, 0x1A76},
            {Opcode.CMSG_WARDEN_DATA, 0x1702},
            {Opcode.MSG_MOVE_UPDATE_RUN_SPEED, 0x176F},
            {Opcode.MSG_MULTIPLE_PACKETS, 0x10BD}, // CMSG_ADDON_REGISTERED_PREFIXES and SMSG_QUESTGIVER_QUEST_COMPLETE
            {Opcode.MSG_MULTIPLE_PACKETS1, 0x10B6}, // SMSG_SPELL_START and ???
            {Opcode.MSG_QUERY_NEXT_MAIL_TIME, 0x1F61},
            {Opcode.MSG_UNKNOWN_4262, 0x10A6},
            {Opcode.MSG_UNKNOWN_5125, 0x1405},
            {Opcode.MSG_UNKNOWN_5750, 0x1676},
            {Opcode.MSG_UNKNOWN_5383, 0x1507},
            {Opcode.MSG_UNKNOWN_6127, 0x17EF},
            {Opcode.MSG_UNKNOWN_6315, 0x18AB},
            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x0890},
            {Opcode.SMSG_ACTION_BUTTONS, 0x0096},
            {Opcode.SMSG_ADDON_INFO, 0x0128},
            {Opcode.SMSG_ALL_ACHIEVEMENT_DATA, 0x0816},
            {Opcode.SMSG_ARENA_SEASON_WORLD_STATE, 0x0189},
            {Opcode.SMSG_ATTACKERSTATEUPDATE, 0x1BC0},
            {Opcode.SMSG_ATTACKSTART, 0x0427},  // correct?
            {Opcode.SMSG_ATTACKSTOP, 0x050F},   // correct?
            {Opcode.SMSG_AURA_UPDATE, 0x19B3},
            {Opcode.SMSG_AUTH_CHALLENGE, 0x016A},
            {Opcode.SMSG_AUTH_RESPONSE, 0x090E},
            {Opcode.SMSG_BATTLE_PET_JOURNAL, 0x05B5},
            {Opcode.SMSG_BINDPOINTUPDATE, 0x0404},
            {Opcode.SMSG_CANCEL_AUTO_REPEAT, 0x041C},
            {Opcode.SMSG_CHAR_ENUM, 0x0193},
            {Opcode.SMSG_CLIENTCACHE_VERSION, 0x0825},
            {Opcode.SMSG_CHANNEL_NOTIFY, 0x1760},
            {Opcode.SMSG_CORPSE_RECLAIM_DELAY, 0x04BB},
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0x01B4},
            {Opcode.SMSG_CRITERIA_UPDATE, 0x082C},
            {Opcode.SMSG_CRITERIA_UNKNOWN, 0x0537},
            {Opcode.SMSG_DB_REPLY, 0x0025},
            {Opcode.SMSG_DEFENSE_MESSAGE, 0x0826},
            {Opcode.SMSG_DESTROY_OBJECT, 0x04BD},
            {Opcode.SMSG_EMOTE, 0x1B7D},
            {Opcode.SMSG_EQUIPMENT_SET_LIST, 0x0938},
            {Opcode.SMSG_FAILED_PLAYER_CONDITION, 0x0524},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS, 0x00B9},
            {Opcode.SMSG_FLIGHT_SPLINE_SYNC, 0x1692},
            {Opcode.SMSG_FORCE_SEND_QUEUED_PACKETS, 0x004A},
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0x0015},
            {Opcode.SMSG_GOSSIP_MESSAGE, 0x1508},
            {Opcode.SMSG_GOSSIP_POI, 0x1E0C},
            {Opcode.SMSG_GROUP_LIST, 0x013D},
            {Opcode.SMSG_GUILD_ACHIEVEMENT_DATA, 0x0C5E},
            {Opcode.SMSG_GUILD_QUERY_RESPONSE, 0x0D42},
            {Opcode.SMSG_GUILD_RANK, 0x0446},
            {Opcode.SMSG_GUILD_PARTY_STATE_RESPONSE, 0x0C73},
            {Opcode.SMSG_GUILD_ROSTER, 0x044E},
            {Opcode.SMSG_GUILD_NEWS_TEXT, 0x0D47},
            {Opcode.SMSG_GUILD_REPUTATION_WEEKLY_CAP, 0x0457},
            {Opcode.SMSG_HIGHEST_THREAT_UPDATE, 0x0012},
            {Opcode.SMSG_HOTFIX_INFO, 0x0416},
            {Opcode.SMSG_INITIAL_SPELLS, 0x1534},
            {Opcode.SMSG_INIT_CURRENCY, 0x0494},
            {Opcode.SMSG_INIT_WORLD_STATES, 0x0929},
            {Opcode.SMSG_INITIALIZE_FACTIONS, 0x090F},
            {Opcode.SMSG_ITEM_ENCHANT_TIME_UPDATE, 0x0437},
            {Opcode.SMSG_LEARNED_SPELL, 0x0830},
            {Opcode.SMSG_LEVELUP_INFO, 0x0402},
            {Opcode.SMSG_LFG_PLAYER_INFO, 0x01A2},
            {Opcode.SMSG_LIST_INVENTORY, 0x088D},
            {Opcode.SMSG_LOAD_CUF_PROFILES, 0x009D},
            {Opcode.SMSG_LOGIN_SETTIMESPEED, 0x01AF},
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x0896},
            {Opcode.SMSG_LOOT_MONEY_NOTIFY, 0x052D},
            {Opcode.SMSG_LOOT_RELEASE_RESPONSE, 0x048F},
            {Opcode.SMSG_MAIL_LIST_RESULT, 0x088C},
            {Opcode.SMSG_MESSAGECHAT, 0x092F},
            {Opcode.SMSG_MONSTER_MOVE, 0x137A},
            {Opcode.SMSG_MOTD, 0x082A},
            {Opcode.SMSG_MOVE_UPDATE_FLIGHT_SPEED, 0x160E},
            {Opcode.SMSG_SPLINE_MOVE_GRAVITY_DISABLE, 0x1207},
            {Opcode.SMSG_NAME_QUERY_RESPONSE, 0x00B7},
            {Opcode.SMSG_NEW_WORLD, 0x01AE},
            {Opcode.SMSG_NPC_TEXT_UPDATE, 0x0886},
            {Opcode.SMSG_PAGE_TEXT_QUERY_RESPONSE, 0x0114},
            {Opcode.SMSG_PERIODICAURALOG, 0x1097},
            {Opcode.SMSG_PET_NAME_QUERY_RESPONSE, 0x05A1},
            {Opcode.SMSG_PLAY_SCENE, 0x01A9},
            {Opcode.SMSG_PLAY_SOUND, 0x04A1},
            {Opcode.SMSG_PLAY_SPELL_VISUAL_KIT, 0x01A5},
            {Opcode.SMSG_PLAYER_MOVE, 0x139F},
            {Opcode.SMSG_QUESTGIVER_QUEST_DETAILS, 0x142D},
            {Opcode.SMSG_QUEST_NPC_QUERY_RESPONSE, 0x193E},
            {Opcode.SMSG_QUEST_POI_QUERY_RESPONSE, 0x183F},
            {Opcode.SMSG_QUEST_QUERY_RESPONSE, 0x19AB},
            {Opcode.SMSG_REALM_QUERY_RESPONSE, 0x042B},
            {Opcode.SMSG_REALM_SPLIT, 0x0099},
            {Opcode.SMSG_REDIRECT_CLIENT, 0x0143},
            {Opcode.SMSG_REMOVED_SPELL, 0x0523},
            {Opcode.SMSG_REQUEST_CEMETERY_LIST_RESPONSE, 0x0499},
            {Opcode.SMSG_SEND_SERVER_LOCATION, 0x0883},
            {Opcode.SMSG_SEND_UNLEARN_SPELLS, 0x11A2},
            {Opcode.SMSG_SET_FLAT_SPELL_MODIFIER, 0x1530},
            {Opcode.SMSG_SET_PCT_SPELL_MODIFIER, 0x1C06},
            {Opcode.SMSG_SET_PLAY_HOVER_ANIM, 0x0196},
            {Opcode.SMSG_SET_PHASE_SHIFT, 0x0919},
            {Opcode.SMSG_SET_PROFICIENCY, 0x012C},
            {Opcode.SMSG_SET_VIGNETTE, 0x00B1},
            {Opcode.SMSG_SPELL_CATEGORY_COOLDOWN, 0x1434},
            {Opcode.SMSG_SPELLENERGIZELOG, 0x1492},
            {Opcode.SMSG_SPELLHEALLOG, 0x1594},
            {Opcode.SMSG_SPELLNONMELEEDAMAGELOG, 0x1085},
            {Opcode.SMSG_SPELL_GO, 0x1C17},
            {Opcode.SMSG_SPLINE_MOVE_SET_SWIM_SPEED, 0x1662},
            {Opcode.SMSG_SPLINE_MOVE_SET_WALK_SPEED, 0x16FB},
            {Opcode.SMSG_SPLINE_MOVE_ROOT, 0x177B},
            {Opcode.SMSG_SUSPEND_COMMS, 0x0862},
            {Opcode.SMSG_SUSPEND_TOKEN_RESPONSE, 0x0422},
            {Opcode.SMSG_TALENTS_INFO, 0x0924},
            {Opcode.SMSG_TEXT_EMOTE, 0x003B},
            {Opcode.SMSG_THREAT_UPDATE, 0x000B},
            {Opcode.SMSG_TIME_SYNC_REQ, 0x08A6},
            {Opcode.SMSG_TOTEM_CREATED, 0x0904},
            {Opcode.SMSG_TRANSFER_PENDING, 0x08B5},
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x1F35},
            {Opcode.SMSG_UNKNOWN_3, 0x0003},
            {Opcode.SMSG_UNKNOWN_8, 0x0008},
            {Opcode.SMSG_UNKNOWN_19, 0x0013},
            {Opcode.SMSG_UNKNOWN_22, 0x0016},
            {Opcode.SMSG_UNKNOWN_23, 0x0017},
            {Opcode.SMSG_UNKNOWN_24, 0x0018},
            {Opcode.SMSG_UNKNOWN_54, 0x0036},
            {Opcode.SMSG_UNKNOWN_56, 0x0038},
            {Opcode.SMSG_UNKNOWN_57, 0x0039},
            {Opcode.SMSG_UNKNOWN_62, 0x003E},
            {Opcode.SMSG_UNKNOWN_67, 0x0043},
            {Opcode.SMSG_UNKNOWN_140, 0x008C},
            {Opcode.SMSG_UNKNOWN_141, 0x008D},
            {Opcode.SMSG_UNKNOWN_147, 0x0093},
            {Opcode.SMSG_UNKNOWN_152, 0x0098},
            {Opcode.SMSG_UNKNOWN_159, 0x009F},
            {Opcode.SMSG_UNKNOWN_163, 0x00A3},
            {Opcode.SMSG_UNKNOWN_169, 0x00A9},
            {Opcode.SMSG_UNKNOWN_170, 0x00AA},
            {Opcode.SMSG_UNKNOWN_272, 0x0110},
            {Opcode.SMSG_UNKNOWN_275, 0x0113},
            {Opcode.SMSG_UNKNOWN_305, 0x0131},
            {Opcode.SMSG_UNKNOWN_316, 0x013C},
            {Opcode.SMSG_UNKNOWN_389, 0x0185},
            {Opcode.SMSG_UNKNOWN_410, 0x019A},
            {Opcode.SMSG_UNKNOWN_429, 0x01AD},
            {Opcode.SMSG_UNKNOWN_438, 0x01B6},
            {Opcode.SMSG_UNKNOWN_442, 0x01BA},
            {Opcode.SMSG_UNKNOWN_443, 0x01BB},
            {Opcode.SMSG_UNKNOWN_274, 0x0112},
            {Opcode.SMSG_UNKNOWN_289, 0x0121},
            {Opcode.SMSG_UNKNOWN_1024, 0x0400},
            {Opcode.SMSG_UNKNOWN_1031, 0x0407},
            {Opcode.SMSG_UNKNOWN_1036, 0x040C},
            {Opcode.SMSG_UNKNOWN_1059, 0x0423},
            {Opcode.SMSG_UNKNOWN_1060, 0x0424},
            {Opcode.SMSG_UNKNOWN_1090, 0x0442},
            {Opcode.SMSG_UNKNOWN_1119, 0x045F},
            {Opcode.SMSG_UNKNOWN_1135, 0x046F},
            {Opcode.SMSG_UNKNOWN_1139, 0x0473},
            {Opcode.SMSG_UNKNOWN_1166, 0x048E},
            {Opcode.SMSG_UNKNOWN_1182, 0x049E},
            {Opcode.SMSG_UNKNOWN_1189, 0x04A5},
            {Opcode.SMSG_UNKNOWN_1194, 0x04AA},
            {Opcode.SMSG_UNKNOWN_1197, 0x04AD},
            {Opcode.SMSG_UNKNOWN_1203, 0x04B3},
            {Opcode.SMSG_UNKNOWN_1299, 0x0513},
            {Opcode.SMSG_UNKNOWN_1318, 0x0526},
            {Opcode.SMSG_UNKNOWN_1321, 0x0529}, // group opcode
            {Opcode.SMSG_UNKNOWN_1347, 0x0543},
            {Opcode.SMSG_UNKNOWN_1394, 0x0572},
            {Opcode.SMSG_UNKNOWN_1358, 0x054E},
            {Opcode.SMSG_UNKNOWN_1406, 0x057E},
            {Opcode.SMSG_UNKNOWN_1444, 0x05A4},
            {Opcode.SMSG_UNKNOWN_1454, 0x05AE},
            {Opcode.SMSG_UNKNOWN_1464, 0x05B8},
            {Opcode.SMSG_UNKNOWN_1457, 0x05B1},
            {Opcode.SMSG_UNKNOWN_1162, 0x048A},
            {Opcode.SMSG_UNKNOWN_1183, 0x049F},
            {Opcode.SMSG_UNKNOWN_1431, 0x0597},
            {Opcode.SMSG_UNKNOWN_1446, 0x05A6},
            {Opcode.SMSG_UNKNOWN_1460, 0x05B4},
            {Opcode.SMSG_UNKNOWN_2048, 0x0800},
            {Opcode.SMSG_UNKNOWN_2055, 0x0807},
            {Opcode.SMSG_UNKNOWN_2057, 0x0809},
            {Opcode.SMSG_UNKNOWN_2066, 0x0812},
            {Opcode.SMSG_UNKNOWN_2080, 0x0820},
            {Opcode.SMSG_UNKNOWN_2087, 0x0827},
            {Opcode.SMSG_UNKNOWN_2093, 0x082D},
            {Opcode.SMSG_UNKNOWN_2109, 0x083D},
            {Opcode.SMSG_UNKNOWN_2178, 0x0882},
            {Opcode.SMSG_UNKNOWN_2202, 0x089A},
            {Opcode.SMSG_UNKNOWN_2205, 0x089D},
            {Opcode.SMSG_UNKNOWN_2227, 0x08B3},
            {Opcode.SMSG_UNKNOWN_2235, 0x08BB},
            {Opcode.SMSG_UNKNOWN_2305, 0x0901},
            {Opcode.SMSG_UNKNOWN_2307, 0x0903},
            {Opcode.SMSG_UNKNOWN_2321, 0x0911},
            {Opcode.SMSG_UNKNOWN_2327, 0x0917},
            {Opcode.SMSG_UNKNOWN_2338, 0x0922},
            {Opcode.SMSG_UNKNOWN_1317, 0x0525},
            {Opcode.SMSG_UNKNOWN_3139, 0x0C43},
            {Opcode.SMSG_UNKNOWN_4374, 0x1116},
            {Opcode.SMSG_UNKNOWN_4393, 0x1129},
            {Opcode.SMSG_UNKNOWN_4501, 0x1195},
            {Opcode.SMSG_UNKNOWN_4518, 0x11A6},
            {Opcode.SMSG_UNKNOWN_4522, 0x11AA},
            {Opcode.SMSG_UNKNOWN_4703, 0x125F},
            {Opcode.SMSG_UNKNOWN_4710, 0x1266},
            {Opcode.SMSG_UNKNOWN_4763, 0x129B},
            {Opcode.SMSG_UNKNOWN_4822, 0x12D6},
            {Opcode.SMSG_UNKNOWN_4890, 0x131A},
            {Opcode.SMSG_UNKNOWN_4930, 0x1342},
            {Opcode.SMSG_UNKNOWN_4950, 0x1356},
            {Opcode.SMSG_UNKNOWN_5298, 0x14B2},
            {Opcode.SMSG_UNKNOWN_5376, 0x1500},
            {Opcode.SMSG_UNKNOWN_5410, 0x1522},
            {Opcode.SMSG_UNKNOWN_5525, 0x1595},
            {Opcode.SMSG_UNKNOWN_5553, 0x15B1},
            {Opcode.SMSG_UNKNOWN_5659, 0x161B},
            {Opcode.SMSG_UNKNOWN_5702, 0x1646},
            {Opcode.SMSG_UNKNOWN_5722, 0x165A},
            {Opcode.SMSG_UNKNOWN_5727, 0x165F},
            {Opcode.SMSG_UNKNOWN_5738, 0x166A},
            {Opcode.SMSG_UNKNOWN_5838, 0x16CE},
            {Opcode.SMSG_UNKNOWN_5942, 0x173A},
            {Opcode.SMSG_UNKNOWN_5963, 0x174B},
            {Opcode.SMSG_UNKNOWN_5971, 0x1753},
            {Opcode.SMSG_UNKNOWN_6018, 0x1782},
            {Opcode.SMSG_UNKNOWN_6047, 0x179F},
            {Opcode.SMSG_UNKNOWN_6174, 0x181E},
            {Opcode.SMSG_UNKNOWN_6285, 0x188D},
            {Opcode.SMSG_UNKNOWN_6327, 0x18B7},
            {Opcode.SMSG_UNKNOWN_6418, 0x1912},
            {Opcode.SMSG_UNKNOWN_6454, 0x1936},
            {Opcode.SMSG_UNKNOWN_6528, 0x1980},
            {Opcode.SMSG_UNKNOWN_6742, 0x1A56},
            {Opcode.SMSG_UNKNOWN_6754, 0x1A62},
            {Opcode.SMSG_UNKNOWN_6775, 0x1A77},
            {Opcode.SMSG_UPDATE_LAST_INSTANCE, 0x05B2},
            {Opcode.SMSG_UPDATE_OBJECT, 0x17D9},
            {Opcode.SMSG_UPDATE_CURRENCY_WEEK_LIMIT, 0x019D},
            {Opcode.SMSG_UPDATE_WORLD_STATE, 0x090D},
            {Opcode.SMSG_WARDEN_DATA, 0x0002},
            {Opcode.SMSG_WEATHER, 0x04A7},
            {Opcode.SMSG_WEEKLY_SPELL_USAGE, 0x1124},
            {Opcode.SMSG_WORLD_SERVER_INFO, 0x052E},
        };
    }
}
