<!DOCTYPE html>
<html lang="id">
<head>
  <meta charset="UTF-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
  <title>Form Interaktif</title>
  <style>
    body {
      font-family: 'Segoe UI', sans-serif;
      display: flex;
      flex-direction: column;
      align-items: center;
      margin-top: 60px;
      background-color: #f9f9f9;
    }

    .form-container {
      background: white;
      padding: 30px;
      border-radius: 10px;
      box-shadow: 0 0 10px rgba(0,0,0,0.1);
      width: 300px;
    }

    input {
      display: block;
      width: 100%;
      padding: 10px;
      margin-bottom: 5px;
      border: 1px solid #ccc;
      border-radius: 6px;
      transition: all 0.2s ease;
    }

    input.error {
      border-color: red;
      background-color: #ffecec;
    }

    .error-message {
      color: red;
      font-size: 0.85em;
      margin-bottom: 10px;
    }

    button {
      width: 100%;
      padding: 10px;
      background-color: #4a90e2;
      border: none;
      color: white;
      border-radius: 6px;
      font-weight: bold;
      cursor: pointer;
    }

    button:hover {
      background-color: #357ab8;
    }

    #hasil {
      margin-top: 20px;
      color: #333;
      font-size: 1.1em;
      font-weight: bold;
    }
  </style>
</head>
<body>

  <div class="form-container">
    <h2>Isi Data Kamu</h2>

    <input type="text" id="inputNama" placeholder="Nama kamu">
    <div id="errorNama" class="error-message"></div>

    <input type="number" id="inputUmur" placeholder="Umur kamu">
    <div id="errorUmur" class="error-message"></div>

    <input type="text" id="inputHobi" placeholder="Hobi kamu">
    <div id="errorHobi" class="error-message"></div>

    <button id="tombolKirim">Kirim</button>
  </div>

  <div id="hasil"></div>

  <script>
    const tombol = document.getElementById('tombolKirim');
    const inputNama = document.getElementById('inputNama');
    const inputUmur = document.getElementById('inputUmur');
    const inputHobi = document.getElementById('inputHobi');

    const errorNama = document.getElementById('errorNama');
    const errorUmur = document.getElementById('errorUmur');
    const errorHobi = document.getElementById('errorHobi');
    const hasil = document.getElementById('hasil');

    tombol.addEventListener('click', function () {
      // Reset error & style
      errorNama.innerText = '';
      errorUmur.innerText = '';
      errorHobi.innerText = '';
      hasil.innerText = '';
      inputNama.classList.remove('error');
      inputUmur.classList.remove('error');
      inputHobi.classList.remove('error');

      const nama = inputNama.value.trim();
      const umur = parseInt(inputUmur.value.trim());
      const hobi = inputHobi.value.trim();

      let isValid = true;

      if (nama === '') {
        errorNama.innerText = 'Nama tidak boleh kosong';
        inputNama.classList.add('error');
        isValid = false;
      }

      if (isNaN(umur) || umur < 1 || umur > 120) {
        errorUmur.innerText = 'Umur harus antara 1 - 120';
        inputUmur.classList.add('error');
        isValid = false;
      }

      if (hobi === '') {
        errorHobi.innerText = 'Hobi tidak boleh kosong';
        inputHobi.classList.add('error');
        isValid = false;
      }

      if (isValid) {
        hasil.innerText = `Halo ${nama}! Umur kamu ${umur} tahun. Hobimu adalah ${hobi}.`;
      }
    });
  </script>

</body>
</html>
