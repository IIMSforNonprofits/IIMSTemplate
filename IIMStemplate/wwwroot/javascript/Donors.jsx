class Donors extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    // =======================================
    // Methods 
    // componentDidMount() - async call to db for paginated donors list. Proof of life is full list. 
    // =======================================
    render() {
        return (
            <div className="Donors">I am a Donors landing page.
            </div>
            // Render as a table with clickable table row 
            // ForEach to render the object into the table.
        );
    }
}

export Donors;