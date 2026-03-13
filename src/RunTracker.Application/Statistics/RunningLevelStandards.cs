namespace RunTracker.Application.Statistics;

public static class RunningLevelStandards
{
    // Level index: 0=Beginner, 1=Novice, 2=Intermediate, 3=Advanced, 4=Elite, 5=WR
    public static readonly string[] LevelNames = ["Beginner", "Novice", "Intermediate", "Advanced", "Elite", "WR"];

    // Age groups: 10,15,20,25,30,35,40,45,50,55,60,65,70,75,80,85,90
    public static readonly int[] AgeGroups = [10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90];

    // Supported distances in metres
    public static readonly int[] Distances = [5000, 10000, 21097, 42195];
    public static readonly string[] DistanceLabels = ["5K", "10K", "Half Marathon", "Marathon"];

    // ── 5K ──────────────────────────────────────────────────────────────────

    // Male 5K times in seconds [ageGroupIndex][levelIndex 0-5 where 5=WR]
    private static readonly int[,] Male5KSeconds =
    {
        // Beg,  Nov,  Int,  Adv,  Eli,  WR
        { 2259, 1889, 1616, 1415, 1267,  922 }, // 10
        { 1955, 1634, 1399, 1225, 1097,  798 }, // 15
        { 1889, 1579, 1351, 1184, 1060,  771 }, // 20
        { 1889, 1579, 1351, 1184, 1060,  771 }, // 25
        { 1889, 1579, 1352, 1184, 1060,  771 }, // 30
        { 1919, 1605, 1373, 1203, 1077,  783 }, // 35
        { 1989, 1663, 1423, 1246, 1116,  812 }, // 40
        { 2065, 1727, 1478, 1294, 1159,  843 }, // 45
        { 2147, 1795, 1536, 1346, 1205,  877 }, // 50
        { 2236, 1870, 1600, 1401, 1255,  913 }, // 55
        { 2333, 1951, 1669, 1462, 1309,  952 }, // 60
        { 2438, 2039, 1745, 1528, 1368,  995 }, // 65
        { 2563, 2143, 1834, 1606, 1438, 1046 }, // 70
        { 2755, 2303, 1971, 1726, 1546, 1125 }, // 75
        { 3049, 2550, 2182, 1911, 1711, 1245 }, // 80
        { 3508, 2933, 2510, 2198, 1968, 1432 }, // 85
        { 4268, 3569, 3054, 2675, 2395, 1742 }, // 90
    };

    // Female 5K times in seconds [ageGroupIndex][levelIndex 0-4]
    private static readonly int[,] Female5KSeconds =
    {
        // Beg,  Nov,  Int,  Adv,  Eli
        { 2489, 2116, 1833, 1620, 1460 }, // 10
        { 2234, 1900, 1646, 1454, 1310 }, // 15
        { 2127, 1808, 1567, 1384, 1247 }, // 20
        { 2127, 1808, 1567, 1384, 1247 }, // 25
        { 2127, 1808, 1567, 1384, 1247 }, // 30
        { 2140, 1820, 1577, 1393, 1256 }, // 35
        { 2185, 1858, 1609, 1422, 1282 }, // 40
        { 2263, 1924, 1667, 1473, 1327 }, // 45
        { 2379, 2023, 1753, 1549, 1396 }, // 50
        { 2516, 2140, 1854, 1638, 1476 }, // 55
        { 2669, 2270, 1967, 1738, 1566 }, // 60
        { 2843, 2418, 2094, 1851, 1668 }, // 65
        { 3040, 2585, 2240, 1979, 1783 }, // 70
        { 3267, 2778, 2407, 2127, 1916 }, // 75
        { 3537, 3007, 2605, 2302, 2075 }, // 80
        { 3982, 3386, 2934, 2592, 2336 }, // 85
        { 4799, 4081, 3535, 3124, 2815 }, // 90
    };

    // ── 10K ─────────────────────────────────────────────────────────────────

    private static readonly int[,] Male10KSeconds =
    {
        // Beg,  Nov,  Int,  Adv,  Eli
        { 4689, 3913, 3345, 2928, 2623 }, // 10
        { 4059, 3388, 2895, 2535, 2271 }, // 15
        { 3930, 3279, 2803, 2454, 2198 }, // 20
        { 3930, 3279, 2803, 2454, 2198 }, // 25
        { 3930, 3279, 2803, 2454, 2198 }, // 30
        { 3966, 3309, 2829, 2476, 2218 }, // 35
        { 4078, 3403, 2909, 2546, 2281 }, // 40
        { 4243, 3541, 3026, 2650, 2373 }, // 45
        { 4422, 3690, 3154, 2761, 2474 }, // 50
        { 4617, 3853, 3293, 2883, 2583 }, // 55
        { 4830, 4031, 3445, 3016, 2702 }, // 60
        { 5063, 4225, 3611, 3162, 2832 }, // 65
        { 5320, 4440, 3795, 3322, 2976 }, // 70
        { 5672, 4733, 4046, 3542, 3173 }, // 75
        { 6236, 5205, 4448, 3894, 3488 }, // 80
        { 7134, 5954, 5089, 4455, 3991 }, // 85
        { 8644, 7214, 6165, 5398, 4835 }, // 90
    };

    private static readonly int[,] Female10KSeconds =
    {
        // Beg,  Nov,  Int,  Adv,  Eli
        { 5315, 4513, 3903, 3446, 3104 }, // 10
        { 4732, 4018, 3475, 3067, 2763 }, // 15
        { 4438, 3768, 3259, 2877, 2592 }, // 20
        { 4429, 3760, 3253, 2871, 2586 }, // 25
        { 4438, 3768, 3259, 2877, 2592 }, // 30
        { 4493, 3815, 3300, 2913, 2624 }, // 35
        { 4603, 3908, 3380, 2984, 2688 }, // 40
        { 4774, 4053, 3506, 3095, 2788 }, // 45
        { 5021, 4263, 3687, 3255, 2932 }, // 50
        { 5320, 4517, 3907, 3449, 3107 }, // 55
        { 5658, 4804, 4155, 3668, 3304 }, // 60
        { 6042, 5130, 4437, 3916, 3528 }, // 65
        { 6481, 5503, 4760, 4201, 3785 }, // 70
        { 6989, 5934, 5133, 4531, 4081 }, // 75
        { 7709, 6546, 5662, 4998, 4502 }, // 80
        { 8924, 7577, 6554, 5785, 5211 }, // 85
        {11098, 9422, 8150, 7194, 6480 }, // 90
    };

    // ── Half Marathon ────────────────────────────────────────────────────────

    private static readonly int[,] MaleHalfSeconds =
    {
        // Beg,   Nov,   Int,   Adv,   Eli
        {10408,  8701,  7436,  6502,  5816 }, // 10
        { 9007,  7530,  6435,  5627,  5033 }, // 15
        { 8697,  7271,  6213,  5433,  4860 }, // 20
        { 8697,  7271,  6213,  5433,  4860 }, // 25
        { 8697,  7271,  6213,  5433,  4860 }, // 30
        { 8745,  7311,  6248,  5463,  4886 }, // 35
        { 8969,  7499,  6408,  5604,  5012 }, // 40
        { 9340,  7809,  6673,  5835,  5219 }, // 45
        { 9748,  8149,  6964,  6090,  5447 }, // 50
        {10192,  8521,  7282,  6367,  5695 }, // 55
        {10679,  8928,  7629,  6672,  5967 }, // 60
        {11214,  9376,  8012,  7006,  6266 }, // 65
        {11807,  9871,  8435,  7376,  6597 }, // 70
        {12619, 10550,  9015,  7884,  7051 }, // 75
        {13922, 11639,  9946,  8697,  7779 }, // 80
        {16010, 13385, 11439, 10002,  8946 }, // 85
        {19561, 16354, 13975, 12221, 10930 }, // 90
    };

    private static readonly int[,] FemaleHalfSeconds =
    {
        // Beg,   Nov,   Int,   Adv,   Eli
        {12272, 10452,  9051,  7989,  7191 }, // 10
        {10693,  9106,  7886,  6961,  6266 }, // 15
        { 9854,  8392,  7267,  6414,  5774 }, // 20
        { 9779,  8328,  7212,  6366,  5730 }, // 25
        { 9782,  8330,  7214,  6368,  5732 }, // 30
        { 9874,  8409,  7282,  6427,  5786 }, // 35
        {10103,  8604,  7451,  6577,  5920 }, // 40
        {10491,  8935,  7737,  6829,  6148 }, // 45
        {11068,  9426,  8163,  7205,  6486 }, // 50
        {11760, 10015,  8674,  7656,  6891 }, // 55
        {12545, 10684,  9252,  8166,  7351 }, // 60
        {13442, 11447,  9914,  8750,  7876 }, // 65
        {14476, 12328, 10677,  9424,  8483 }, // 70
        {15684, 13357, 11567, 10210,  9190 }, // 75
        {17314, 14745, 12769, 11271, 10145 }, // 80
        {20100, 17118, 14824, 13085, 11778 }, // 85
        {25190, 21452, 18578, 16398, 14761 }, // 90
    };

    // ── Marathon ─────────────────────────────────────────────────────────────

    private static readonly int[,] MaleMarathonSeconds =
    {
        // Beg,   Nov,   Int,   Adv,   Eli
        {21327, 17957, 15433, 13550, 12151 }, // 10
        {18456, 15540, 13355, 11726, 10515 }, // 15
        {17821, 15005, 12896, 11322, 10153 }, // 20
        {17821, 15005, 12896, 11322, 10153 }, // 25
        {17821, 15005, 12896, 11322, 10153 }, // 30
        {17920, 15088, 12967, 11385, 10209 }, // 35
        {18380, 15476, 13300, 11677, 10472 }, // 40
        {19140, 16116, 13850, 12160, 10905 }, // 45
        {19974, 16818, 14454, 12690, 11380 }, // 50
        {20885, 17585, 15113, 13269, 11899 }, // 55
        {21882, 18425, 15835, 13903, 12467 }, // 60
        {22980, 19349, 16629, 14600, 13092 }, // 65
        {24194, 20371, 17507, 15371, 13784 }, // 70
        {25854, 21769, 18709, 16426, 14730 }, // 75
        {28536, 24028, 20650, 18130, 16258 }, // 80
        {32868, 27675, 23784, 20882, 18726 }, // 85
        {40283, 33918, 29150, 25593, 22950 }, // 90
    };

    private static readonly int[,] FemaleMarathonSeconds =
    {
        // Beg,   Nov,   Int,   Adv,   Eli
        {24168, 20713, 18040, 15996, 14447 }, // 10
        {21493, 18421, 16044, 14226, 12848 }, // 15
        {20074, 17205, 14984, 13286, 12000 }, // 20
        {19945, 17095, 14889, 13201, 11923 }, // 25
        {19945, 17095, 14889, 13201, 11923 }, // 30
        {20024, 17162, 14947, 13253, 11970 }, // 35
        {20432, 17511, 15252, 13523, 12214 }, // 40
        {21230, 18195, 15847, 14051, 12691 }, // 45
        {22481, 19268, 16782, 14880, 13439 }, // 50
        {23976, 20549, 17897, 15869, 14332 }, // 55
        {25683, 22012, 19171, 16999, 15353 }, // 60
        {27652, 23700, 20641, 18302, 16530 }, // 65
        {29948, 25668, 22355, 19822, 17902 }, // 70
        {32681, 28010, 24396, 21631, 19536 }, // 75
        {36868, 31598, 27520, 24402, 22039 }, // 80
        {44156, 37845, 32961, 29226, 26396 }, // 85
        {58252, 49926, 43483, 38555, 34822 }, // 90
    };

    // ── Public API ───────────────────────────────────────────────────────────

    /// <summary>
    /// Returns the standard time in seconds for a given gender, distance, age and level.
    /// For level 5 (WR), falls back to scaling from the Male 5K WR value.
    /// </summary>
    public static int GetStandardSeconds(bool isMale, int distanceM, int ageGroup, int levelIndex)
    {
        if (levelIndex == 5)
        {
            // WR: scale from Male 5K WR using Riegel, apply gender ratio
            var ageBracket = GetAgeBracket(ageGroup);
            var base5KWr = Male5KSeconds[ageBracket, 5];
            var scaled = base5KWr * Math.Pow((double)distanceM / 5000.0, 1.06);
            return (int)(isMale ? scaled : scaled * 1.12);
        }

        var table = GetTable(isMale, distanceM);
        var idx = GetAgeBracket(ageGroup);
        return table[idx, levelIndex];
    }

    /// <summary>
    /// Returns a continuous level score (0=Beginner … 4=Elite) for a given time.
    /// Values outside this range are extrapolated (slower than Beginner → negative,
    /// faster than Elite → above 4).
    /// Uses linear age interpolation between the 5-year age groups.
    /// </summary>
    public static double GetLevelScore(bool isMale, int distanceM, int age, double timeSec)
    {
        var (lo, hi, t) = GetAgeInterp(age);
        var table = GetTable(isMale, distanceM);
        var times = InterpolateLevels(table, lo, hi, t);
        return TimeToScore(times, timeSec);
    }

    /// <summary>
    /// Predicts the finish time (seconds) for a given level score at the target distance.
    /// Uses linear age interpolation between the 5-year age groups.
    /// </summary>
    public static double PredictTime(bool isMale, int distanceM, int age, double levelScore)
    {
        var (lo, hi, t) = GetAgeInterp(age);
        var table = GetTable(isMale, distanceM);
        var times = InterpolateLevels(table, lo, hi, t);
        return ScoreToTime(times, levelScore);
    }

    /// <summary>
    /// Returns (0–100) percentile estimate for a given time at a distance.
    /// </summary>
    public static double ComputePercentile(bool isMale, int distanceM, int age, double timeSec)
    {
        double[] percentileBreaks = [99.9, 95, 75, 50, 25, 10];
        for (int i = 0; i < LevelNames.Length; i++)
        {
            var threshold = GetStandardSeconds(isMale, distanceM, age, i);
            if (timeSec <= threshold)
                return percentileBreaks[i];
        }
        return 5;
    }

    // ── Private helpers ──────────────────────────────────────────────────────

    private static int[,] GetTable(bool isMale, int distanceM) => distanceM switch
    {
        <= 5000  => isMale ? Male5KSeconds      : Female5KSeconds,
        <= 10000 => isMale ? Male10KSeconds     : Female10KSeconds,
        <= 21097 => isMale ? MaleHalfSeconds    : FemaleHalfSeconds,
        _        => isMale ? MaleMarathonSeconds : FemaleMarathonSeconds,
    };

    // Returns (loIdx, hiIdx, fraction) for age interpolation
    private static (int lo, int hi, double t) GetAgeInterp(int age)
    {
        var clampedAge = Math.Clamp(age, AgeGroups[0], AgeGroups[^1]);
        for (int i = 0; i < AgeGroups.Length - 1; i++)
        {
            if (clampedAge <= AgeGroups[i + 1])
            {
                var t = (double)(clampedAge - AgeGroups[i]) / (AgeGroups[i + 1] - AgeGroups[i]);
                return (i, i + 1, t);
            }
        }
        return (AgeGroups.Length - 2, AgeGroups.Length - 1, 1.0);
    }

    // Interpolate between two age rows, returning an array of 5 level times (seconds)
    private static double[] InterpolateLevels(int[,] table, int lo, int hi, double t)
    {
        var count = Math.Min(table.GetLength(1), 5); // cap at 5 (Beginner…Elite)
        var result = new double[count];
        for (int l = 0; l < count; l++)
            result[l] = table[lo, l] + t * (table[hi, l] - table[lo, l]);
        return result;
    }

    // Convert a time in seconds to a continuous score 0–4 (with extrapolation)
    private static double TimeToScore(double[] times, double timeSec)
    {
        // times[0]=Beginner (slowest) … times[4]=Elite (fastest)
        // lower time = faster = higher score
        for (int i = 0; i < times.Length - 1; i++)
        {
            if (timeSec >= times[i + 1] && timeSec <= times[i])
            {
                var frac = (times[i] - timeSec) / (times[i] - times[i + 1]);
                return i + frac;
            }
        }
        // Extrapolate below Beginner
        if (timeSec > times[0])
        {
            var frac = (times[0] - timeSec) / (times[0] - times[1]);
            return frac; // negative
        }
        // Extrapolate above Elite
        var efrac = (times[4] - timeSec) / (times[3] - times[4]);
        return 4.0 + efrac;
    }

    // Convert a continuous level score back to a predicted time
    private static double ScoreToTime(double[] times, double score)
    {
        var lo = (int)Math.Floor(score);
        var frac = score - lo;

        if (lo < 0)
        {
            // Extrapolate below Beginner
            return times[0] - frac * (times[0] - times[1]);
        }
        if (lo >= times.Length - 1)
        {
            // Extrapolate above Elite
            return times[4] - frac * (times[3] - times[4]);
        }
        return times[lo] + frac * (times[lo + 1] - times[lo]);
    }

    private static int GetAgeBracket(int age)
    {
        if (age <= 10) return 0;
        if (age <= 12) return 0;
        if (age <= 17) return 1;
        if (age <= 22) return 2;
        if (age <= 27) return 3;
        if (age <= 32) return 4;
        if (age <= 37) return 5;
        if (age <= 42) return 6;
        if (age <= 47) return 7;
        if (age <= 52) return 8;
        if (age <= 57) return 9;
        if (age <= 62) return 10;
        if (age <= 67) return 11;
        if (age <= 72) return 12;
        if (age <= 77) return 13;
        if (age <= 82) return 14;
        if (age <= 87) return 15;
        return 16;
    }
}
