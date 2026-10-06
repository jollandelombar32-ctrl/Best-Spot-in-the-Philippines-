<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title>Beautiful Spots in the Philippines</title>

    <style>

        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            scroll-behavior: smooth;
        }

        body {
            font-family: Arial, sans-serif;
            
            color: #17324d;
            line-height: 1.7;
        }

        /* HEADER */

        header {
            min-height: 520px;

            background:
                linear-gradient(
                    rgba(0, 40, 70, 0.45),
                    rgba(0, 30, 50, 0.65)
                ),
                url("https://images.unsplash.com/photo-1518509562904-e7ef99cdcc86?auto=format&fit=crop&w=1600&q=90")
                center/cover no-repeat;

            color: white;

            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: center;

            text-align: center;

            padding: 40px 20px;
        }

        header h1 {
            font-size: 55px;
            margin-bottom: 15px;
            text-shadow: 3px 3px 10px #000;
        }

        header p {
            font-size: 20px;
            max-width: 750px;
        }

        .explore-btn {
            display: inline-block;
            margin-top: 25px;
            padding: 14px 30px;

            background: #00a8cc;
            color: white;

            text-decoration: none;
            border-radius: 30px;

            font-weight: bold;

            transition: 0.3s;
        }

        .explore-btn:hover {
            background: #007fa3;
            transform: scale(1.08);
        }


        /* NAVIGATION */

        nav {
            background: #063b50;

            position: sticky;
            top: 0;

            z-index: 1000;

            box-shadow: 0 4px 15px rgba(0,0,0,0.2);
        }

        nav ul {
            list-style: none;

            display: flex;
            justify-content: center;

            flex-wrap: wrap;
        }

        nav a {
            display: block;

            padding: 15px 18px;

            color: white;

            text-decoration: none;

            font-weight: bold;

            transition: 0.3s;
        }

        nav a:hover {
            background: #00a8cc;
        }


        /* MAIN */

        main {
            max-width: 1150px;

            margin: auto;

            padding: 50px 20px;
        }


        /* PLACE CARDS */

        article {
            background: white;

            margin: 50px 0;

            border-radius: 20px;

            overflow: hidden;

            box-shadow:
                0 8px 25px rgba(0,0,0,0.12);

            transition: 0.4s;
        }

        article:hover {
            transform: translateY(-8px);

            box-shadow:
                0 15px 35px rgba(0,0,0,0.22);
        }

        figure {
            margin: 0;

            overflow: hidden;
        }

        figure img {
            width: 100%;

            height: 430px;

            object-fit: cover;

            display: block;

            transition: 0.5s;
        }

        article:hover figure img {
            transform: scale(1.05);
        }

        figcaption {
            background: #063b50;

            color: white;

            padding: 13px 20px;

            font-style: italic;
        }

        article h2 {
            color: #007c9e;

            font-size: 32px;

            padding: 25px 30px 5px;
        }

        article p {
            padding: 10px 30px 30px;

            font-size: 17px;
        }


        /* VIDEO */

        .video-section {
            text-align: center;

            margin: 80px 0;
        }

        .video-section h2 {
            color: #006d8f;

            font-size: 36px;

            margin-bottom: 10px;
        }

        .video-section > p {
            font-size: 18px;

            margin-bottom: 25px;
        }

        .video-container {
            width: 100%;

            max-width: 900px;

            aspect-ratio: 16 / 9;

            margin: 30px auto;

            border-radius: 20px;

            overflow: hidden;

            box-shadow:
                0 12px 35px rgba(0,0,0,0.25);

            background: #000;
        }

        .video-container iframe {
            width: 100%;
            height: 100%;

            border: 0;

            display: block;
        }

        .video-note {
            color: #006d8f;

            font-weight: bold;
        }


        /* AUDIO */

        .audio-section {
            background: #063b50;

            color: white;

            text-align: center;

            padding: 40px 20px;

            border-radius: 20px;

            margin: 60px 0;
        }

        .audio-section h2 {
            margin-bottom: 10px;

            font-size: 30px;
        }

        .audio-section p {
            margin-bottom: 15px;
        }

        audio {
            width: 90%;

            max-width: 500px;
        }


        /* FOOTER */

        footer {
            background: #032b3b;

            color: white;

            text-align: center;

            padding: 30px;
        }

        footer p {
            margin: 5px;
        }


        /* MOBILE */

        @media (max-width: 700px) {

            header {
                min-height: 420px;
            }

            header h1 {
                font-size: 38px;
            }

            header p {
                font-size: 17px;
            }

            nav ul {
                flex-direction: column;

                text-align: center;
            }

            figure img {
                height: 280px;
            }

            article h2 {
                font-size: 27px;
            }

        }

    </style>

</head>


<body>


<!-- HEADER -->

<header>

    <h1>Beautiful Spots in the Philippines 🇵🇭</h1>

    <p>
        Explore five breathtaking destinations
        and discover the beauty of the Philippines.
    </p>

    <a href="#boracay" class="explore-btn">
        Explore Now
    </a>

</header>


<!-- NAVIGATION -->

<nav>

    <ul>

        <li>
            <a href="#boracay">Boracay</a>
        </li>

        <li>
            <a href="#underground-river">
                Underground River
            </a>
        </li>

        <li>
            <a href="#chocolate-hills">
                Chocolate Hills
            </a>
        </li>

        <li>
            <a href="#mayon">
                Mayon Volcano
            </a>
        </li>

        <li>
            <a href="#siargao">
                Siargao
            </a>
        </li>

        <li>
            <a href="#video">🎥 Video</a>
        </li>

        <li>
            <a href="#audio">🎵 Audio</a>
        </li>

    </ul>

</nav>


<main>


    <!-- 1. BORACAY -->

    <article id="boracay">

        <h2>1. Boracay</h2>

        <figure>

            <img
                src="https://images.unsplash.com/photo-1518509562904-e7ef99cdcc86?auto=format&fit=crop&w=1400&q=90"
                alt="Beautiful tropical beach with clear blue water">

            <figcaption>
                Boracay is famous for its white sand beaches,
                clear blue water, and beautiful sunsets.
            </figcaption>

        </figure>

        <p>
            Boracay is one of the most popular tourist destinations
            in the Philippines. Visitors can enjoy swimming,
            relaxing on the beach, island hopping, and watching
            beautiful sunsets.
        </p>

    </article>


    <!-- 2. PUERTO PRINCESA UNDERGROUND RIVER -->

    <article id="underground-river">

        <h2>2. Puerto Princesa Underground River</h2>

        <figure>

            <img
                src="https://images.unsplash.com/photo-1500530855697-b586d89ba3ee?auto=format&fit=crop&w=1400&q=90"
                alt="Natural limestone cave and tropical landscape">

            <figcaption>
                A spectacular underground river surrounded
                by limestone rock formations.
            </figcaption>

        </figure>

        <p>
            The Puerto Princesa Underground River is located
            in Palawan. Visitors can travel through the limestone
            cave by boat and see amazing natural rock formations.
        </p>

    </article>


    <!-- 3. CHOCOLATE HILLS -->

    <article id="chocolate-hills">

        <h2>3. Chocolate Hills, Bohol</h2>

        <figure>

            <img
                src="https://images.unsplash.com/photo-1500534623283-312aade485b7?auto=format&fit=crop&w=1400&q=90"
                alt="Beautiful green hills and tropical landscape">

            <figcaption>
                The Chocolate Hills are one of the most famous
                natural attractions in Bohol.
            </figcaption>

        </figure>

        <p>
            The Chocolate Hills are known for their unusual
            cone-shaped formations. During the dry season,
            the hills can turn brown, giving them their famous name.
        </p>

    </article>


    <!-- 4. MAYON VOLCANO -->

    <article id="mayon">

        <h2>4. Mayon Volcano</h2>

        <figure>

            <img
                src="https://images.unsplash.com/photo-1464822759023-fed622ff2c3b?auto=format&fit=crop&w=1400&q=90"
                alt="Majestic mountain landscape under a blue sky">

            <figcaption>
                Mayon Volcano is famous for its beautiful
                symmetrical cone shape.
            </figcaption>

        </figure>

        <p>
            Located in Albay, Mayon Volcano is one of the most
            recognizable natural landmarks in the Philippines.
            Its symmetrical shape makes it a popular photography subject.
        </p>

    </article>


    <!-- 5. SIARGAO -->

    <article id="siargao">

        <h2>5. Siargao</h2>

        <figure>

            <img
                src="https://images.unsplash.com/photo-1502680390469-be75c86b636f?auto=format&fit=crop&w=1400&q=90"
                alt="Surfer riding a wave in a tropical ocean">

            <figcaption>
                Siargao is famous for surfing, beautiful beaches,
                and its relaxing island atmosphere.
            </figcaption>

        </figure>

        <p>
            Siargao is known as one of the best surfing destinations
            in the Philippines. Visitors can enjoy Cloud 9,
            island hopping, lagoons, beaches, and beautiful sunsets.
        </p>

    </article>


    <!-- VIDEO -->

    <section id="video" class="video-section">

        <h2>🎥 Beautiful Palawan</h2>

        <p>
            Watch this video and experience the beauty of Coron, Palawan.
        </p>

        <div class="video-container">

            <iframe
                src="https://www.youtube.com/embed/ni6SR_WGceY"
                title="Your Happy Place in Coron, Palawan"
                allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"
                allowfullscreen>
            </iframe>

        </div>

        <p class="video-note">
            🌴 Experience the beauty of Coron, Palawan!
        </p>

    </section>


    <!-- AUDIO -->

    <section id="audio" class="audio-section">

        <h2>🎵 Piliin Mo ang Pilipinas</h2>

        <p>
            Play the music while exploring the beautiful Philippines.
        </p>

        <audio controls loop>

            <source
                src="audio/piliin-mo-ang-pilipinas.mp3"
                type="audio/mpeg">

            Your browser does not support the audio element.

        </audio>

        <p>
            <small>
                Put your MP3 file inside the
                <strong>audio</strong> folder.
            </small>
        </p>

    </section>


</main>


<!-- FOOTER -->

<footer>

    <p>🇵🇭 Made with ❤️ for the Philippines</p>

    <p>Beautiful Spots in the Philippines</p>

    <p>Group 3 | IT101</p>

</footer>


</body>

</html>