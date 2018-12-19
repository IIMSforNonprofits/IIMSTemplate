class DetailMetrics extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }

    // This is a new standalone page to be rendered since a lot more information on the specific metrics job will be present 
    render() {
        return (
            <div className="DetailMetrics">I am a DetailMetrics view.
            </div>
            // example content is sql query, description, data visualization 
            // ? back button to metrics page or browser back button ?
        );
    }
}

export DetailMetrics;