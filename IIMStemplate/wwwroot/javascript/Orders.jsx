class Orders extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    // =======================================
    // Methods 
    // componentDidMount() - async call to db for paginated orders list. Proof of life is full list. 
    // =======================================

    render() {
        return (
            <div className="Orders">I am a Orders dashboard landing page.
            </div>
            // Render as a table with clickable table row 
            // ForEach to render the object into the table. 
        );
    }
}

export Orders;