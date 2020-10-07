# リストの中身をランダムで入れ替えるコード

Unityプロジェクト
Listの中身をSystem.Guid.NewGuid()を生成してシャッフルする。
判る人はListShuffleクラスだけ使って下さい。

ListShuffleクラス
→GetListShuffle（　List<int> ）:渡されたリストの中身をシャッフルして返す
  
TestCodeクラス
リストのシャッフルをおこないそれをログに表示するというサンプルコード

・プロジェクト説明
ListShuffleTestシーンを開いて再生するだけで1~5の数字がシャッフルされた結果がログに表示される。
あなたのプロジェクト・ゲームで使う場合はListShuffleのファイルだけを移して同じように使って下さい。
