# Farm Shopping & Barn Management

[🇹🇷 Türkçe](#türkçe) | [🇬🇧 English](#english)

---

## English

### 📌 Overview
**Farm Shopping & Barn Management** is a C# Windows Forms (.NET 8.0) desktop application designed for managing a virtual farm. The application allows users to oversee animal husbandry, manage barn inventory, and engage in buying and selling animals or farm products through an integrated shop system.

### 🚀 Features
* **Animal Management:** Manage various farm animals including Cows, Chickens, Lambs, Goats, and Bees.
* **Farm Interface:** Interact with the farm environment, feed animals, and collect their produce (milk, eggs, wool, honey, etc.).
* **Storage/Barn Management:** Keep track of your inventory, stored products, and resources.
* **Shop System:** Buy new animals to expand your farm or sell collected products for profit.
* **Modern UI:** Utilizes `FontAwesome.Sharp` for a clean, modern, and icon-rich user interface.

### 💻 Technologies Used
* **C#**
* **.NET 8.0**
* **Windows Forms** (WinForms)
* **FontAwesome.Sharp** (For UI Icons)

### 📂 Folder Structure
* `Entities/`: Contains the core models and classes for the animals (`Cow.cs`, `Chicken.cs`, `Lamb.cs`, `Goat.cs`, `Bee.cs`) and base entities.
* `Forms/`: Contains the visual components of the application, such as `MainForm`, `FarmForm`, `ShopForm`, `StorageForm`, and `PopUpForms`.
* `Management/`: Handles the core UI routing and logic, such as switching between different panels (`PanelManager.cs`).

### ⚙️ How to Run
1. **Clone the repository:**
   ```bash
   git clone <repository-url>
   ```
2. **Open the Project:** Open the `FarmShoppingForm.csproj` file using **Visual Studio 2022** (or a newer version).
3. **Prerequisites:** Ensure that the **.NET 8.0 SDK** is installed on your system.
4. **Restore Packages:** Visual Studio should automatically restore the required NuGet packages (like `FontAwesome.Sharp`). If not, right-click the solution and select "Restore NuGet Packages".
5. **Run:** Press `F5` or click the "Start" button to build and run the application.

---
<br>

## Türkçe

### 📌 Genel Bakış
**Farm Shopping & Barn Management (Çiftlik Alışverişi ve Ahır Yönetimi)**, sanal bir çiftliği yönetmek için tasarlanmış C# Windows Forms (.NET 8.0) tabanlı bir masaüstü uygulamasıdır. Kullanıcılar uygulama üzerinden hayvan bakımı yapabilir, ahır envanterini yönetebilir ve entegre dükkan sistemi sayesinde hayvan veya çiftlik ürünlerinin alım-satım işlemlerini gerçekleştirebilirler.

### 🚀 Özellikler
* **Hayvan Yönetimi:** İnek, Tavuk, Kuzu, Keçi ve Arı gibi çeşitli çiftlik hayvanlarının yönetimini sağlar.
* **Çiftlik Arayüzü:** Çiftlik ortamı ile etkileşime girin, hayvanları besleyin ve ürünlerini (süt, yumurta, yün, bal vb.) toplayın.
* **Depo/Ahır Yönetimi:** Envanterinizi, depolanan ürünleri ve kaynaklarınızı takip edin.
* **Dükkan (Shop) Sistemi:** Çiftliğinizi büyütmek için yeni hayvanlar satın alın veya topladığınız ürünleri satarak gelir elde edin.
* **Modern Arayüz:** Temiz, modern ve ikon odaklı bir kullanıcı deneyimi için `FontAwesome.Sharp` kütüphanesi kullanılmıştır.

### 💻 Kullanılan Teknolojiler
* **C#**
* **.NET 8.0**
* **Windows Forms** (WinForms)
* **FontAwesome.Sharp** (Kullanıcı arayüzü ikonları için)

### 📂 Proje Yapısı
* `Entities/`: Hayvanlar (`Cow.cs`, `Chicken.cs`, `Lamb.cs`, `Goat.cs`, `Bee.cs`) ve temel objeler için çekirdek modelleri ve sınıfları içerir.
* `Forms/`: Uygulamanın görsel bileşenlerini barındırır (`MainForm`, `FarmForm`, `ShopForm`, `StorageForm` ve `PopUpForms`).
* `Management/`: Paneller arası geçiş ve temel arayüz mantığını (`PanelManager.cs`) yönetir.

### ⚙️ Nasıl Çalıştırılır
1. **Projeyi Klonlayın:**
   ```bash
   git clone <repository-url>
   ```
2. **Projeyi Açın:** `FarmShoppingForm.csproj` dosyasını **Visual Studio 2022** (veya daha güncel bir sürüm) ile açın.
3. **Gereksinimler:** Sisteminizde **.NET 8.0 SDK**'nın kurulu olduğundan emin olun.
4. **Paketleri Yükleyin:** Visual Studio gerekli NuGet paketlerini (`FontAwesome.Sharp` vb.) otomatik olarak yükleyecektir. Yüklenmezse çözüme (solution) sağ tıklayıp "Restore NuGet Packages" seçeneğini seçin.
5. **Çalıştırın:** `F5` tuşuna basarak veya "Başlat" butonuna tıklayarak projeyi derleyip çalıştırın.