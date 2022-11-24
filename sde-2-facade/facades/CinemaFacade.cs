public class CinemaFacade {
    Amplifier amp;
    Tuner tuner;
    DvdPlayer dvd;
    CdPlayer cd;
    Projector projector;
    TheaterLights lights;
    Screen screen;
    PopcornPopper popper;

    public CinemaFacade() {
        this.amp = new Amplifier("Top-O-Line Amplifier");
        this.tuner = new Tuner("Top-O-Line AM/FM Tuner", amp);
        this.dvd = new DvdPlayer("Top-O-Line DVD Player", amp);
        this.cd = new CdPlayer("Top-O-Line CD Player", amp);
        this.projector = new Projector("Top-O-Line Projector", dvd);
        this.lights = new TheaterLights("Theater Ceiling Lights");
        this.screen = new Screen("Theater Screen", 50, 50);
        this.popper = new PopcornPopper("Popcorn Popper");
    }

    public void watchMovie(string movie){
        this.popper.on();
        this.popper.pop();
        this.lights.dim(9);
        this.screen.down();
        this.projector.on();
        this.projector.wideScreenMode();
        this.amp.on();
        this.amp.setDvd(dvd);
        this.amp.setSurroundSound();
        this.amp.setVolume(5);
        this.dvd.on();
        this.dvd.play(movie);
    }

    public void endMovie(){
        this.popper.off();
        this.lights.on();
        this.screen.up();
        this.projector.off();
        this.amp.off();
        this.dvd.stop();
        this.dvd.eject();
        this.dvd.off();
    }

    public void listenToTrack(string track){
        this.lights.on();
        this.amp.on();
        this.amp.setVolume(5);
        this.amp.setCd(cd);
        this.amp.setStereoSound();
        this.cd.on();
        this.cd.play(track);
    }

    public void endTrack(){
        this.amp.off();
        this.amp.setCd(cd);
        this.cd.eject();
        this.cd.off();
    }

    public void listenToRadio(double frequency){
        this.tuner.on();
        this.tuner.setFrequency(frequency);
        this.amp.on();
        this.amp.setVolume(5);
        this.amp.setTuner(tuner);
    }

    public void stopRadio(){
        this.tuner.off();
        this.amp.off();
    }

}