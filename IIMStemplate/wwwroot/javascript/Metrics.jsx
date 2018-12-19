class Metrics extends React.Component {
    constructor(props) {
        super(props);
        this.state = {} // caching of results from initial population of links for faster page load.
    }
    render() {
        return (
            <div className="Metrics">I am a Metrics Dashboard landing page.
            </div>
            // Unordered list of clickable links to detail view(link will be name of query), a brief description 
        );
    }
}

export Metrics;