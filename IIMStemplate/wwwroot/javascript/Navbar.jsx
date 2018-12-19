class Navbar extends React.Component {
    constructor(props) {
        super(props);
        this.state = {} // based on your policy add the level of access to state use this to render different navbar based on level
    }
    render() {
        // Logic that determines which object for policy level to render in the navbar component
        return (
            <div className="Navbar">I am Navbar.
            </div>
            // <div className=Navbar> <ul> <li>{Dashboard}</li> </ul> </div>
        );
    }
}

export Navbar;