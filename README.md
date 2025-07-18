# 三目並べゲーム (Tic-Tac-Toe)

## 概要
C#で作成された三目並べゲームです。コンソールで動作し、人間対AIの対戦が可能です。

## 作業完了報告
課題12および課題13を完了し、AI対戦機能を実装いたしました。また、第一の課題（数字当てゲーム）についても完成しており、こちらのリポジトリでご確認いただけます：[number-game](https://github.com/rakei076/number-game.git)

第一の課題において実行時にエラーが発生する可能性がありましたが、修正済みです。もし何かご不明な点やご質問がございましたら、a24i436yv@ous.jp までご連絡ください。無論何時でも迅速に返信いたします。

## 実行環境
- .NET Core SDK 9.0以上

## 実行方法
```bash
cd TicTacToe
dotnet run
```

## 游戏功能说明

### 游戏规则
- 3x3的棋盘，人类玩家使用○标记，AI使用×标记
- 玩家轮流在空位置下棋
- 第一个在横、竖、斜任意方向形成三子连线的玩家获胜
- 如果棋盘填满且无人获胜则为平局

### 玩家类型
1. **HumanPlayer（人类玩家）**
   - 通过控制台输入行列坐标（0-2）来下棋
   - 输入格式：先输入行号，再输入列号
   - 会进行输入验证，确保输入的是有效数字和范围

2. **RandomPlayer（随机AI玩家）**
   - 自动随机选择空位置下棋
   - 使用随机算法，最多尝试100次找到空位
   - 如果随机失败，会按顺序寻找第一个空位

### 游戏流程
1. 显示初始空棋盘
2. 人类玩家首先下棋（○）
3. AI随机选择位置下棋（×）
4. 轮流进行直到游戏结束
5. 检测胜负并显示结果

### 已知问题
- 胜负判定显示逻辑有误：当检测到获胜时，显示的获胜者可能不正确
- 编译时会有关于null值的警告，但不影响程序运行

### 运行测试结果
- ✅ 程序正常启动和运行
- ✅ 人机对战功能正常
- ✅ 输入验证工作正常
- ✅ 棋盘显示正确
- ✅ AI随机下棋功能正常
- ⚠️ 胜负判定显示需要修正