# VeterinerUygulamasi
# 🐾 Veteriner Kayıt Sistemi

Evcil hayvanların veteriner kayıtlarını yönetmek için geliştirilmiş, modern arayüzlü bir Windows masaüstü uygulaması.

![Uygulama Ekran Görüntüsü](Ekran%20görüntüsü%202026-05-19%20234628.png)

---

## 📋 Proje Hakkında

Bu proje, bir veteriner kliniğinde kullanılabilecek basit ama işlevsel bir **evcil hayvan kayıt yönetim sistemi**dir. Hayvan adı, türü, sahibi ve aşı durumu gibi temel bilgileri SQL Server veritabanında saklar; kayıt ekleme, güncelleme ve silme işlemlerini tek ekrandan gerçekleştirmenize olanak tanır.

Arayüz, standart Windows Forms bileşenlerinin ötesine geçerek elle çizilmiş özel kontroller (`GlowButton`, `ModernCheckBox`, `InputFieldPanel`, `ThemePanel`) ve merkezi bir tema sistemi (`UiTheme`) ile inşa edilmiştir. Sonuç: karanlık, sade ve kullanımı keyifli bir deneyim.

---

## ✨ Özellikler

- **Canlı kayıt listesi** — Uygulama açılır açılmaz tüm kayıtlar otomatik yüklenir
- **Hızlı CRUD işlemleri** — Ekle / Güncelle / Sil tek tıklamayla
- **Aşı durumu takibi** — Checkbox ile anında işaretleme
- **Smooth animasyonlu butonlar** — Hover geçişleri 60 fps timer ile yumuşatılmış
- **Tam dark-mode arayüz** — Göz yormayan, tutarlı renk paleti
- **Double-buffer DataGridView** — Titreşimsiz, akıcı tablo yenileme

---

## 🗂️ Proje Yapısı

```
WindowsFormsApp5/
├── Controls/
│   ├── GlowButton.cs          # Animasyonlu, köşe yuvarlatmalı özel buton
│   ├── InputFieldPanel.cs     # Focus durumunu gösteren input çerçevesi
│   ├── ModernCheckBox.cs      # Özel çizimli checkbox kontrolü
│   ├── ModernTextBox.cs       # Tema uyumlu metin kutusu
│   └── ThemePanel.cs          # Arka plan rengi yönetilen panel
├── Ui/
│   └── UiTheme.cs             # Merkezi renk ve font tanımları
├── Form1.cs                   # Ana form — veritabanı işlemleri burada
├── Form1.Designer.cs          # Otomatik üretilen layout kodu
└── Program.cs                 # Uygulama giriş noktası
```

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji | Versiyon |
|-----------|----------|
| C# | .NET Framework 4.7.2 |
| Windows Forms | .NET Framework built-in |
| SQL Server | SQL Server Express |
| ADO.NET | SqlConnection / SqlCommand |
