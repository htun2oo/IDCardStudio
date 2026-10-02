if (dialog.IncludeCardDesign)
{
    if (dialog.IsLandscape)
    {
        // CR80 Landscape Size (Width: 238, Height: 150)
        CardFrontCanvas.Width = 238;
        CardFrontCanvas.Height = 150;
        CardBackCanvas.Width = 238;
        CardBackCanvas.Height = 150;
    }
    else
    {
        // CR80 Portrait Size (Width: 150, Height: 238)
        CardFrontCanvas.Width = 150;
        CardFrontCanvas.Height = 238;
        CardBackCanvas.Width = 150;
        CardBackCanvas.Height = 238;
    }
}
