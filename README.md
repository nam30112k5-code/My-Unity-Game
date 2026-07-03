
# My Unity Game

Mô tả ngắn: trò chơi platformer 2D — người chơi chạy, nhảy, ăn coin, né trap và đối đầu kẻ địch tuần tra.

Cách chơi nhanh:
- Di chuyển: phím mũi tên trái/phải hoặc `A/D`.
- Nhảy: `Space`.
- Mục tiêu: thu coin tăng điểm, tránh trap và enemy; khi chết sẽ hiện UI Game Over.

Tính năng hiện tại:
- Player di chuyển và nhảy (`PlayerController`).
- Kẻ địch di chuyển theo quãng và đổi hướng (`EnemyMove`).
- Coin và trap trigger điểm/losing (`PlayerCoin`).
- Quản lý điểm, hiển thị và restart (`Gamemanager`).

Chạy dự án:
1. Mở Unity và load project.
2. Mở scene trong `Assets/Scenes` và nhấn Play.

Ghi chú: đã thêm `.gitignore` để tránh commit các thư mục sinh tự động như `Library/` và `Temp/`.

Repo: https://github.com/nam30112k5-code/My-Unity-Game
