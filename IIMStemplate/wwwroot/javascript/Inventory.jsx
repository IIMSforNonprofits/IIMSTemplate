class Inventory extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    // =======================================
    // Methods 
    // componentDidMount() - async call to db for paginated inventory list. Proof of life is full list. 
    // =======================================
    render() {
        return (
            <div className="Inventory">I am an Inventory dashboard landing page.
            </div>
            // Render as a table with clickable table row 
            // ForEach to render the object into the table. 
        );
    }
}

export Inventory;